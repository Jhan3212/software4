using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormAdminRestaurantes : Form
    {
        public FormAdminRestaurantes()
        {
            InitializeComponent();
            CargarRestaurantes();

            btnAgregar.Click += BtnAgregar_Click;
            btnEditar.Click += BtnEditar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnRecargar.Click += BtnRecargar_Click;
        }

        // ------------------------------------------------------
        //  Cargar Restaurantes
        // ------------------------------------------------------
        private void CargarRestaurantes()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT Id, Nombre, Categoria, Imagen FROM Restaurantes";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataRestaurantes.DataSource = dt;

                    // Ocultar ruta imagen si no quieres verla en la tabla
                    dataRestaurantes.Columns["Imagen"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar restaurantes: " + ex.Message);
            }
        }

        // ------------------------------------------------------
        //  Agregar
        // ------------------------------------------------------
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FormRestaurantEditor form = new FormRestaurantEditor(); // modo agregar

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarRestaurantes();
            }
        }

        // ------------------------------------------------------
        //  Editar
        // ------------------------------------------------------
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataRestaurantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un restaurante para editar.");
                return;
            }

            int id = Convert.ToInt32(dataRestaurantes.SelectedRows[0].Cells["Id"].Value);
            string nombre = dataRestaurantes.SelectedRows[0].Cells["Nombre"].Value.ToString();
            string categoria = dataRestaurantes.SelectedRows[0].Cells["Categoria"].Value.ToString();
            string imagen = dataRestaurantes.SelectedRows[0].Cells["Imagen"].Value.ToString();

            FormRestaurantEditor form = new FormRestaurantEditor(id, nombre, categoria, imagen);

            if (form.ShowDialog() == DialogResult.OK)
            {
                CargarRestaurantes();
            }
        }

        // ------------------------------------------------------
        //  Eliminar
        // ------------------------------------------------------
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataRestaurantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un restaurante para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dataRestaurantes.SelectedRows[0].Cells["Id"].Value);
            string nombre = dataRestaurantes.SelectedRows[0].Cells["Nombre"].Value.ToString();

            DialogResult d = MessageBox.Show(
                $"¿Está seguro de eliminar '{nombre}'?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (d == DialogResult.No) return;

            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = "DELETE FROM Restaurantes WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Restaurante eliminado.");
                CargarRestaurantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        // ------------------------------------------------------
        //  Recargar
        // ------------------------------------------------------
        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            CargarRestaurantes();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (dataRestaurantes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un restaurante para gestionar el menú.");
                return;
            }

            int id = Convert.ToInt32(dataRestaurantes.SelectedRows[0].Cells["Id"].Value);
            string nombre = dataRestaurantes.SelectedRows[0].Cells["Nombre"].Value.ToString();

            FormMenuRestaurante frm = new FormMenuRestaurante(id, nombre);
            frm.ShowDialog();
        }
    }
}
