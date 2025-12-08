using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net; // ← Importante para verificar y hashear

namespace GoEats
{
    public partial class FormPerfil : Form
    {
        public FormPerfil()
        {
            InitializeComponent();
            this.Load += FormPerfil_Load;
        }

        private void FormPerfil_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            CargarHistorialPedidos();
        }

        private void CargarDatosUsuario()
        {
            ConexionBD bd = new ConexionBD();
            using (var con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "SELECT Nombre, Email FROM usuarios WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", Sesion.IdUsuario);
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblNombre.Text = dr["Nombre"].ToString();
                    lblEmail.Text = dr["Email"].ToString();
                }
            }
        }

        private void CargarHistorialPedidos()
        {
            flowPedidos.Controls.Clear();

            ConexionBD bd = new ConexionBD();
            using (var con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = @"SELECT Id, Fecha, Total 
                               FROM pedidos 
                               WHERE IdUsuario = @id 
                               ORDER BY Fecha DESC";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", Sesion.IdUsuario);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Font = new System.Drawing.Font("Segoe UI", 10);
                    lbl.Text =
                        $"Pedido #{dr["Id"]}  |  Fecha: {Convert.ToDateTime(dr["Fecha"]).ToString("dd/MM/yyyy")}  |  Total: ${Convert.ToDecimal(dr["Total"]):0.00}";

                    flowPedidos.Controls.Add(lbl);
                }
            }
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevaPass.Text))
            {
                MessageBox.Show("Ingrese una nueva contraseña.");
                return;
            }

            string nuevaPass = txtNuevaPass.Text.Trim();

            // Generar nuevo hash bcrypt
            string nuevoHash = BCrypt.Net.BCrypt.HashPassword(nuevaPass);

            ConexionBD bd = new ConexionBD();
            using (var con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = "UPDATE usuarios SET Password = @pass WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pass", nuevoHash);
                cmd.Parameters.AddWithValue("@id", Sesion.IdUsuario);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Contraseña actualizada correctamente.");
            txtNuevaPass.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Limpiar variables de sesión
            Sesion.IdUsuario = 0;
            Sesion.Nombre = "";
            Sesion.Rol = "";
            Sesion.IdCarrito = 0;

            // Abrir login
            FormLogin login = new FormLogin();
            login.Show();

            // Cerrar TODAS las ventanas de usuario
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "FormLogin")
                    frm.Hide();
            }
        }
    }
}