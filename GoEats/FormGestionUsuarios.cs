using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();

            btnActualizar.Click += BtnActualizar_Click;
            btnCambiarRol.Click += BtnCambiarRol_Click;
            btnEliminar.Click += BtnEliminar_Click;
        }

        // ============================
        //  Cargar lista de usuarios
        // ============================
        private void CargarUsuarios()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = "SELECT Id, Nombre, Email, Rol FROM Usuarios";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }


        // ============================
        //  CAMBIAR ROL
        // ============================
        private void BtnCambiarRol_Click(object sender, EventArgs e)
        {
            if (dataUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = Convert.ToInt32(dataUsuarios.SelectedRows[0].Cells["Id"].Value);
            string rolActual = dataUsuarios.SelectedRows[0].Cells["Rol"].Value.ToString();

            string nuevoRol = rolActual == "admin" ? "cliente" : "admin";

            DialogResult d = MessageBox.Show(
                $"¿Cambiar rol a '{nuevoRol}'?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (d == DialogResult.No) return;

            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = "UPDATE Usuarios SET Rol=@rol WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@rol", nuevoRol);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Rol actualizado.");
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar rol: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ============================
        //  ELIMINAR USUARIO
        // ============================
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = Convert.ToInt32(dataUsuarios.SelectedRows[0].Cells["Id"].Value);
            string email = dataUsuarios.SelectedRows[0].Cells["Email"].Value.ToString();
            string rol = dataUsuarios.SelectedRows[0].Cells["Rol"].Value.ToString();

            if (rol == "admin")
            {
                MessageBox.Show("No puedes eliminar un administrador.");
                return;
            }

            DialogResult d = MessageBox.Show(
                $"¿Eliminar usuario '{email}'?",
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

                    string sql = "DELETE FROM Usuarios WHERE Id=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario eliminado.");
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }
    }
}