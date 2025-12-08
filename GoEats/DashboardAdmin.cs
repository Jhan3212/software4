using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GoEats
{
    public partial class DashboardAdmin : Form
    {
        private string currentUserEmail;

        public DashboardAdmin(string email)
        {
            InitializeComponent();
            currentUserEmail = email;

            // Evento Shown para refrescar siempre que se muestre
            this.Shown += DashboardAdmin_Shown;
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            // Carga inicial
            CargarEstadisticas();
        }

        private void DashboardAdmin_Shown(object sender, EventArgs e)
        {
            // Refrescar al volver a mostrar el formulario
            CargarEstadisticas();
        }

        private void CargarEstadisticas()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    // Cantidad de restaurantes
                    MySqlCommand cmdRest = new MySqlCommand(
                        "SELECT COUNT(*) FROM Restaurantes", con);
                    lblNumRest.Text = cmdRest.ExecuteScalar().ToString();

                    // Cantidad de usuarios clientes
                    MySqlCommand cmdUsers = new MySqlCommand(
                        "SELECT COUNT(*) FROM Usuarios WHERE Rol = 'cliente'", con);
                    lblNumUsers.Text = cmdUsers.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando estadísticas: " + ex.Message);
            }
        }

        private void btnGestionRest_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormAdminRestaurantes frm = new FormAdminRestaurantes())
            {
                frm.ShowDialog();
            }
            // Refrescar estadísticas al volver
            CargarEstadisticas();
            this.Show();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormGestionUsuarios frm = new FormGestionUsuarios())
            {
                frm.ShowDialog();
            }
            // Refrescar estadísticas al volver
            CargarEstadisticas();
            this.Show();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormPedidosAdmin frm = new FormPedidosAdmin())
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
        }
    }
}