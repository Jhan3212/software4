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
            lblUsuario.Text = Sesion.Nombre; // ← Mostrar usuario
            CargarInfoRestaurante();
            CargarPlatos();
        }

        private string BuscarImagen(string nombreArchivo)
        {
            string ruta = Path.Combine(Application.StartupPath, "imagenes", "menus", nombreArchivo);
            return File.Exists(ruta) ? ruta : null;
        }

        private Image CargarImagenSegura(string ruta)
        {
            if (string.IsNullOrEmpty(ruta) || !File.Exists(ruta))
                return null;

            byte[] data = File.ReadAllBytes(ruta);
            using (MemoryStream ms = new MemoryStream(data))
                return Image.FromStream(ms);
        }

        private void CargarInfoRestaurante()
        {
            ConexionBD bd = new ConexionBD();

            using (var con = bd.ObtenerConexion())
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

                        string archivo = dr["Imagen"].ToString();
                        string ruta = Path.Combine(Application.StartupPath, "imagenes", "restaurantes", archivo);

                        var img = CargarImagenSegura(ruta);
                        if (img != null)
                        {
                            picRestaurante.Image = img;
                            picRestaurante.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
        }

        private void CargarPlatos()
        {
            flowMenu.Controls.Clear();
            ConexionBD bd = new ConexionBD();

            using (var con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Id, Nombre, Precio, Imagen FROM menus WHERE IdRestaurante=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idRestaurante);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idMenu = Convert.ToInt32(dr["Id"]);
                        string nombre = dr["Nombre"].ToString();
                        decimal precio = Convert.ToDecimal(dr["Precio"]);
                        string archivo = dr["Imagen"].ToString();

                        CardPlato card = new CardPlato();
                        card.lblNombrePlato.Text = nombre;
                        card.lblPrecio.Text = $"${precio:0.00}";

                        var img = CargarImagenSegura(BuscarImagen(archivo));
                        if (img != null)
                        {
                            card.picPlato.Image = img;
                            card.picPlato.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        card.btnAgregar.Click += (s, e) =>
                        {
                            AgregarAlCarritoBD(idMenu, nombre, precio);
                        };

                        flowMenu.Controls.Add(card);
                    }
                }
            }
        }

        // 🔹 Nuevo método → maneja BD, no UI
        private void AgregarAlCarritoBD(int idMenu, string nombre, decimal precio)
        {
            if (Sesion.IdUsuario == 0)
            {
                MessageBox.Show("Debes iniciar sesión primero.");
                return;
            }

            CarritoItemDAO daoItem = new CarritoItemDAO();
            int idItem = daoItem.AgregarItem(Sesion.IdCarrito, idMenu, 1, precio);

            MessageBox.Show($"Agregado al carrito: {nombre}");

            // No se abre el carrito automáticamente ⚠
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 🔹 Este botón SÍ abre el carrito ya cargado desde BD
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormCarrito carrito = new FormCarrito())
            {
                carrito.ShowDialog();
            }
            this.Show();
        }
       

        private void lblUsuario_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (FormPerfil perfil = new FormPerfil())
            {
                perfil.ShowDialog();
            }
            this.Show();
        }
    }
}