using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormMenuRestaurante : Form
    {
        private int idRestaurante;
        private string nombreRestaurante;

        public FormMenuRestaurante(int idRestaurante, string nombre)
        {
            InitializeComponent();
            this.idRestaurante = idRestaurante;
            this.nombreRestaurante = nombre;
            lblTitulo.Text = $"Menú - {nombre}";
            this.Shown += FormMenuRestaurante_Shown;
        }

        private void FormMenuRestaurante_Shown(object sender, EventArgs e)
        {
            CargarPlatos();
        }

        private void CargarPlatos()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();
                    string sql = "SELECT Id, Nombre, Precio, Imagen FROM menus WHERE IdRestaurante = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", idRestaurante);

                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);

                    dgvPlatos.DataSource = dt;

                    // Visual tweaks
                    dgvPlatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPlatos.ReadOnly = true;
                    dgvPlatos.AllowUserToAddRows = false;
                    dgvPlatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // Hide Imagen column if you don't want to show path
                    if (dgvPlatos.Columns["Imagen"] != null)
                        dgvPlatos.Columns["Imagen"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar platos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var editor = new FormMenuItemEditor(idRestaurante);
            if (editor.ShowDialog() == DialogResult.OK)
                CargarPlatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un plato para editar.");
                return;
            }

            int idMenu = Convert.ToInt32(dgvPlatos.SelectedRows[0].Cells["Id"].Value);
            string nombre = dgvPlatos.SelectedRows[0].Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvPlatos.SelectedRows[0].Cells["Precio"].Value);
            string imagen = dgvPlatos.SelectedRows[0].Cells["Imagen"].Value?.ToString();

            var editor = new FormMenuItemEditor(idRestaurante, idMenu, nombre, precio, imagen);
            if (editor.ShowDialog() == DialogResult.OK)
                CargarPlatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un plato para eliminar.");
                return;
            }

            int idMenu = Convert.ToInt32(dgvPlatos.SelectedRows[0].Cells["Id"].Value);
            string nombre = dgvPlatos.SelectedRows[0].Cells["Nombre"].Value.ToString();

            if (MessageBox.Show($"¿Eliminar '{nombre}'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();
                    string sql = "DELETE FROM menus WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", idMenu);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Plato eliminado.");
                CargarPlatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar plato: " + ex.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarPlatos();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}