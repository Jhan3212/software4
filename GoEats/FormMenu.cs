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

        // ✅ BUSCA LA IMAGEN USANDO SOLO EL NOMBRE DEL ARCHIVO
        private string BuscarImagen(string nombreArchivo)
        {
            try
            {
                string ruta = Path.Combine(
                    Application.StartupPath,
                    "imagenes",
                    "menus",
                    nombreArchivo
                );

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

        // ✅ CARGA LA IMAGEN SIN BLOQUEAR ARCHIVOS (NUNCA SE ROMPE)
        private Image CargarImagenSegura(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    MessageBox.Show("❌ No existe la imagen:\n" + ruta);
                    return null;
                }

                byte[] bytes = File.ReadAllBytes(ruta);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("💥 Error cargando imagen:\n" + ex.Message);
                return null;
            }
        }

        // ✅ CARGA INFO DEL RESTAURANTE
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

                        string rutaCompleta = Path.Combine(
                            Application.StartupPath,
                            "imagenes",
                            "restaurantes",
                            nombreImagen
                        );

                        var img = CargarImagenSegura(rutaCompleta);
                        if (img != null)
                            picRestaurante.Image = img;
                    }
                }
            }
        }

        // ✅ CARGA LOS PLATOS DEL MENÚ
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
                        CardPlato card = new CardPlato();

                        string nombre = dr["Nombre"].ToString();
                        decimal precio = Convert.ToDecimal(dr["Precio"]);
                        string nombreImagen = dr["Imagen"].ToString();

                        card.lblNombrePlato.Text = nombre;
                        card.lblPrecio.Text = "$" + precio.ToString("0.00");

                        string rutaCompleta = BuscarImagen(nombreImagen);
                        var img = CargarImagenSegura(rutaCompleta);

                        if (img != null)
                        {
                            card.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
                            card.picPlato.Image = img;
                        }

                        // ✅ BOTÓN AGREGAR AL CARRITO
                        card.btnAgregar.Click += (s, e) =>
                        {
                            AgregarAlCarrito(nombre, precio, nombreImagen);
                        };

                        flowMenu.Controls.Add(card);
                    }
                }
            }
        }

        // ✅ AGREGA AL CARRITO
        private void AgregarAlCarrito(string nombre, decimal precio, string nombreImagen)
        {
            CardCarrito item = new CardCarrito();

            item.lblNombrePlato.Text = nombre;
            item.lblPrecio.Text = precio.ToString("0.00");
            item.lblCantidad.Text = "Cantidad: 1";

            string rutaCompleta = BuscarImagen(nombreImagen);
            var img = CargarImagenSegura(rutaCompleta);

            if (img != null)
            {
                item.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
                item.picPlato.Image = img;
            }

            // ✅ BOTÓN ELIMINAR
            item.btnEliminar.Click += (s, e) =>
            {
                AppData.Carrito.flowCarrito.Controls.Remove(item);
                AppData.Carrito.ActualizarTotal();
            };

            AppData.Carrito.flowCarrito.Controls.Add(item);
            AppData.Carrito.ActualizarTotal();

            MessageBox.Show("✅ Agregado al carrito");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCarrito carrito = new FormCarrito();
            carrito.ShowDialog();
        }
    }
}
