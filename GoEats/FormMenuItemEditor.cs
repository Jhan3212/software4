using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormMenuItemEditor : Form
    {
        private int idRestaurante;
        private int idMenu = 0; // 0 = nuevo
        private string imagenActual = null;
        private string imagenSeleccionadaPath = null;

        public FormMenuItemEditor(int idRestaurante)
        {
            InitializeComponent();
            this.idRestaurante = idRestaurante;
            lblTitulo.Text = "Agregar Plato";
        }

        // constructor para editar
        public FormMenuItemEditor(int idRestaurante, int idMenu, string nombre, decimal precio, string imagen) : this(idRestaurante)
        {
            this.idMenu = idMenu;
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString("0.00");
            imagenActual = imagen;
            txtImagen.Text = imagen;
            lblTitulo.Text = "Editar Plato";

            if (!string.IsNullOrEmpty(imagen))
            {
                string ruta = Path.Combine(Application.StartupPath, "imagenes", "menus", imagen);
                if (File.Exists(ruta))
                {
                    picPreview.Image = new System.Drawing.Bitmap(ruta);
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imagenSeleccionadaPath = dlg.FileName;
                    txtImagen.Text = Path.GetFileName(imagenSeleccionadaPath);
                    try
                    {
                        picPreview.Image = new System.Drawing.Bitmap(imagenSeleccionadaPath);
                    }
                    catch { }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre del plato.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            // Preparar nombre de imagen para guardar en BD
            string imagenNombreAguardar = imagenActual; // por defecto la actual
            if (!string.IsNullOrEmpty(imagenSeleccionadaPath))
            {
                // copiar a carpeta imagenes/menus con nombre único
                string carpeta = Path.Combine(Application.StartupPath, "imagenes", "menus");
                if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

                string ext = Path.GetExtension(imagenSeleccionadaPath);
                string nuevoNombre = Guid.NewGuid().ToString("N") + ext;
                string destino = Path.Combine(carpeta, nuevoNombre);

                File.Copy(imagenSeleccionadaPath, destino, true);
                imagenNombreAguardar = nuevoNombre;
            }

            try
            {
                ConexionBD bd = new ConexionBD();
                using (var con = bd.ObtenerConexion())
                {
                    con.Open();
                    if (idMenu == 0)
                    {
                        string insert = @"INSERT INTO menus (IdRestaurante, Nombre, Precio, Imagen)
                                          VALUES (@idr, @nom, @precio, @img)";
                        using (var cmd = new MySqlCommand(insert, con))
                        {
                            cmd.Parameters.AddWithValue("@idr", idRestaurante);
                            cmd.Parameters.AddWithValue("@nom", nombre);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@img", imagenNombreAguardar ?? (object)DBNull.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string update = @"UPDATE menus SET Nombre = @nom, Precio = @precio, Imagen = @img WHERE Id = @id";
                        using (var cmd = new MySqlCommand(update, con))
                        {
                            cmd.Parameters.AddWithValue("@nom", nombre);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@img", imagenNombreAguardar ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@id", idMenu);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}