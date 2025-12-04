using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '●'; // Estilo más bonito
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (usuario == "" || pass == "")
            {
                MessageBox.Show("Llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConexionBD bd = new ConexionBD();
                MySqlConnection con = bd.ObtenerConexion();
                con.Open();

                string sql = "SELECT * FROM Usuarios WHERE Email = @user AND Password = @pass";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@user", usuario);   // aquí va el correo
                cmd.Parameters.AddWithValue("@pass", pass);      // aquí va la clave


                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Login exitoso
                    MessageBox.Show("¡Bienvenido!", "GoEats");

                    FormHome home = new FormHome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro reg = new FormRegistro();
            reg.Show();
            this.Hide();
        }
    }
}
