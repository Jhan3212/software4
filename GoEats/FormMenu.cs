using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormMenu : Form
    {
        private int idRestaurante;

        public FormMenu(int idRestaurante)
        {
            InitializeComponent();
            this.idRestaurante = idRestaurante;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            CargarInfoRestaurante();
            CargarPlatos();
        }

        // 🔹 Busca la imagen y devuelve la ruta completa
        private string BuscarImagen(string nombreArchivo)
        {
            try
            {
                string ruta = Path.Combine(Application.StartupPath, "imagenes", "menus", nombreArchivo);
                if (File.Exists(ruta))
                    return ruta;

                MessageBox.Show("❌ No se encontró la imagen:\n" + ruta);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error al buscar imagen:\n" + ex.Message);
                return null;
            }
        }

        // 🔹 Carga la imagen sin bloquear archivos
        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
                    return null;

                byte[] bytes = File.ReadAllBytes(ruta);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        // 🔹 Carga info del restaurante
        private void CargarInfoRestaurante()
        {
            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Nombre, Categoria, Imagen FROM restaurantes WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idRestaurante);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lblNombreRestaurante.Text = dr["Nombre"].ToString();
                        lblCategoriaRestaurante.Text = dr["Categoria"].ToString();

                        string nombreImagen = dr["Imagen"].ToString();
                        string rutaCompleta = Path.Combine(Application.StartupPath, "imagenes", "restaurantes", nombreImagen);
                        var img = CargarImagenSegura(rutaCompleta);
                        if (img != null)
                        {
                            picRestaurante.Image = img;
                            picRestaurante.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
        }

        // 🔹 Carga los platos del menú
        private void CargarPlatos()
        {
            flowMenu.Controls.Clear();
            ConexionBD bd = new ConexionBD();

            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Nombre, Precio, Imagen FROM menus WHERE IdRestaurante=@idRestaurante";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idRestaurante", idRestaurante);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string nombre = dr["Nombre"].ToString();
                        decimal precio = Convert.ToDecimal(dr["Precio"]);
                        string nombreImagen = dr["Imagen"].ToString();

                        CardPlato card = new CardPlato
                        {
                            lblNombrePlato = { Text = nombre },
                            lblPrecio = { Text = $"${precio:0.00}" }
                        };

                        // Carga imagen correctamente
                        string rutaCompleta = BuscarImagen(nombreImagen);
                        var img = CargarImagenSegura(rutaCompleta);
                        if (img != null)
                        {
                            card.picPlato.Image = img;
                            card.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        // Botón agregar al carrito
                        card.btnAgregar.Click += (s, e) => AgregarAlCarrito(nombre, precio, nombreImagen);

                        flowMenu.Controls.Add(card);
                    }
                }
            }
        }

        // 🔹 Agrega al carrito
        private void AgregarAlCarrito(string nombre, decimal precio, string nombreImagen)
        {
            // Crear instancia del carrito si no existe
            if (AppData.Carrito == null || AppData.Carrito.IsDisposed)
                AppData.Carrito = new FormCarrito();

            CardCarrito item = new CardCarrito
            {
                lblNombrePlato = { Text = nombre },
                lblPrecio = { Text = precio.ToString("0.00") },
                lblCantidad = { Text = "Cantidad: 1" }
            };

            string rutaCompleta = BuscarImagen(nombreImagen);
            var img = CargarImagenSegura(rutaCompleta);
            if (img != null)
            {
                item.picPlato.Image = img;
                item.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Botón eliminar
            item.btnEliminar.Click += (s, e) =>
            {
                AppData.Carrito.flowCarrito.Controls.Remove(item);
                AppData.Carrito.ActualizarTotal();
            };

            AppData.Carrito.flowCarrito.Controls.Add(item);
            AppData.Carrito.ActualizarTotal();

            MessageBox.Show("✅ Agregado al carrito");
        }

        private void btnAtras_Click(object sender, EventArgs e) => this.Close();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Abrir carrito compartido
            if (AppData.Carrito == null || AppData.Carrito.IsDisposed)
                AppData.Carrito = new FormCarrito();

            AppData.Carrito.Show();
            AppData.Carrito.BringToFront();
        }
    }
}
