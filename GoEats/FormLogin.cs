using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using BCrypt.Net;

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
            txtPass.PasswordChar = '●';
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
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    // Ahora NO comparamos contraseña aquí
                    string sql = "SELECT Id, Nombre, Rol, Password FROM usuarios WHERE Email = @user LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@user", usuario);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.Read())
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                        dr.Close();
                        return;
                    }

                    // Extraemos los valores
                    int idUsuario = Convert.ToInt32(dr["Id"]);
                    string nombre = dr["Nombre"].ToString();
                    string rol = dr["Rol"].ToString();
                    string hashGuardado = dr["Password"].ToString();

                    dr.Close(); // Cerramos antes de abrir otra consulta

                    // Verificar hash con bcrypt
                    bool valido = BCrypt.Net.BCrypt.Verify(pass, hashGuardado);
                    if (!valido)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                        return;
                    }

                    // -------------------------
                    // GUARDAR SESIÓN
                    // -------------------------
                    Sesion.IdUsuario = idUsuario;
                    Sesion.Nombre = nombre;
                    Sesion.Rol = rol;

                    // -------------------------
                    // CARGAR / CREAR CARRITO
                    // -------------------------
                    CarritoDAO carritoDao = new CarritoDAO();
                    Sesion.IdCarrito = carritoDao.ObtenerCarritoActivo(idUsuario);

                    MessageBox.Show($"¡Bienvenido {nombre}!", "GoEats");

                    if (rol == "admin")
                    {
                        DashboardAdmin admin = new DashboardAdmin(nombre);
                        admin.Show();
                    }
                    else
                    {
                        FormHome home = new FormHome();
                        home.Show();
                    }

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
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