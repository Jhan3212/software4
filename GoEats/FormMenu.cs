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

        // 🔎 FUNCIÓN PARA DETECTAR EXTENSIÓN AUTOMÁTICAMENTE
        private string BuscarImagenConExtension(string rutaRelativa)
        {
            try
            {
                string baseDir = Application.StartupPath;
                string rutaBase = Path.Combine(baseDir, rutaRelativa.Replace("/", "\\"));

                string dir = Path.GetDirectoryName(rutaBase);
                string file = Path.GetFileName(rutaBase);

                if (!Directory.Exists(dir))
                    return null;

                string[] extensiones = { ".jpg", ".jpeg", ".png", ".bmp" };

                foreach (var ext in extensiones)
                {
                    string ruta = Path.Combine(dir, file + ext);
                    if (File.Exists(ruta))
                        return ruta;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

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

        private void CargarInfoRestaurante()
        {
            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Nombre, Categoria, Imagen FROM Restaurantes WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idRestaurante);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lblNombreRestaurante.Text = dr["Nombre"].ToString();
                        lblCategoriaRestaurante.Text = dr["Categoria"].ToString();

                        string ruta = dr["Imagen"].ToString();
                        string rutaCompleta = BuscarImagenConExtension(ruta);

                        if (rutaCompleta != null)
                        {
                            picRestaurante.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            Console.WriteLine("⚠ Imagen no encontrada: " + ruta);
                        }
                    }
                }
            }
        }

        private void CargarPlatos()
        {
            flowMenu.Controls.Clear();

            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Nombre, Precio, Imagen FROM Menus WHERE IdRestaurante=@idRestaurante";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idRestaurante", idRestaurante);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        CardPlato card = new CardPlato();

                        string nombre = dr["Nombre"].ToString();
                        decimal precio = Convert.ToDecimal(dr["Precio"]);
                        string ruta = dr["Imagen"].ToString();
                        string rutaCompleta = BuscarImagenConExtension(ruta);

                        card.lblNombrePlato.Text = nombre;
                        card.lblPrecio.Text = "$" + precio.ToString("0.00");

                        Console.WriteLine("Ruta buscada: " + ruta);
                        Console.WriteLine("Ruta encontrada: " + rutaCompleta);

                        if (rutaCompleta != null)
                        {
                            card.picPlato.Image = Image.FromFile(rutaCompleta);
                        }
                        else
                        {
                            Console.WriteLine("⚠ Imagen no encontrada: " + ruta);
                        }

                        // evento del botón agregar
                        card.btnAgregar.Click += (s, e) =>
                        {
                            AgregarAlCarrito(nombre, precio, ruta);
                        };

                        flowMenu.Controls.Add(card);
                    }
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarAlCarrito(string nombre, decimal precio, string imagenRuta)
        {
            CardCarrito item = new CardCarrito();

            item.lblNombrePlato.Text = nombre;
            item.lblPrecio.Text = precio.ToString("0.00");
            item.lblCantidad.Text = "Cantidad: 1";

            string rutaCompleta = BuscarImagenConExtension(imagenRuta);

            if (rutaCompleta != null)
            {
                item.picPlato.Image = Image.FromFile(rutaCompleta);
            }
            else
            {
                Console.WriteLine("⚠ Imagen no encontrada en carrito: " + imagenRuta);
            }

            // botón eliminar del carrito
            item.btnEliminar.Click += (s, e) =>
            {
                AppData.Carrito.flowCarrito.Controls.Remove(item);
                AppData.Carrito.ActualizarTotal();
            };

            // agregar al carrito
            AppData.Carrito.flowCarrito.Controls.Add(item);
            AppData.Carrito.ActualizarTotal();

            MessageBox.Show("Agregado al carrito");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCarrito carrito = new FormCarrito();
            carrito.ShowDialog();
        }
    }
}
