using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            CargarRestaurantes();
        }

        private void CargarRestaurantes()
        {
            flowRestaurantes.Controls.Clear();

            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();

                string sql = "SELECT * FROM restaurantes";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CardRestaurante card = new CardRestaurante();

                    card.lblNombre.Text = dr["Nombre"].ToString();
                    card.lblCategoria.Text = dr["Categoria"].ToString();

                    string nombreImagen = dr["Imagen"].ToString();

                    string rutaCompleta = Path.Combine(
                        Application.StartupPath,
                        "imagenes",
                        "restaurantes",
                        nombreImagen
                    );

                    if (File.Exists(rutaCompleta))
                    {
                        using (var bmpTemp = new Bitmap(rutaCompleta))
                        {
                            card.picImagen.Image = new Bitmap(bmpTemp);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imagen no encontrada:\n" + rutaCompleta);
                    }

                    int id = Convert.ToInt32(dr["Id"]);
                    card.btnVer.Click += (s, e) => AbrirMenu(id);

                    flowRestaurantes.Controls.Add(card);
                }
            }
        }

        private void AbrirMenu(int idRestaurante)
        {
            FormMenu menu = new FormMenu(idRestaurante);
            menu.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
