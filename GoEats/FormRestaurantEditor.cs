using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormRestaurantEditor : Form
    {
        private int restauranteId = 0;
        private bool modoEdicion = false;

        public FormRestaurantEditor()
        {
            InitializeComponent();
            lblTitulo.Text = "Agregar Restaurante";

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => this.Close();
            btnExaminar.Click += BtnExaminar_Click;
        }

        public FormRestaurantEditor(int id, string nombre, string categoria, string imagen)
        {
            InitializeComponent();
            lblTitulo.Text = "Editar Restaurante";

            restauranteId = id;
            modoEdicion = true;

            txtNombre.Text = nombre;
            txtCategoria.Text = categoria;
            txtImagen.Text = imagen;

            if (File.Exists(imagen))
                picPreview.ImageLocation = imagen;

            btnGuardar.Click += BtnGuardar_Click;
            btnCancelar.Click += (s, e) => this.Close();
            btnExaminar.Click += BtnExaminar_Click;
        }

        // ---------------------------------------
        //  Seleccionar imagen
        // ---------------------------------------
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ImÃ¡genes|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = ofd.FileName;
                picPreview.ImageLocation = ofd.FileName;
            }
        }

        // ---------------------------------------
        //  Guardar / Actualizar
        // ---------------------------------------
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string categoria = txtCategoria.Text.Trim();
            string imagen = txtImagen.Text.Trim();

            if (nombre == "" || categoria == "" || imagen == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    MySqlCommand cmd;

                    if (!modoEdicion)
                    {
                        string sql = "INSERT INTO Restaurantes (Nombre, Categoria, Imagen) VALUES (@n, @c, @i)";
                        cmd = new MySqlCommand(sql, con);
                    }
                    else
                    {
                        string sql = "UPDATE Restaurantes SET Nombre=@n, Categoria=@c, Imagen=@i WHERE Id=@id";
                        cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", restauranteId);
                    }

                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@c", categoria);
                    cmd.Parameters.AddWithValue("@i", imagen);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(modoEdicion ? "Restaurante actualizado." : "Restaurante agregado.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}