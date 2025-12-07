using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Frodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
            btnRegistrar.Click += BtnRegistrar_Click;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string usuario = txtUsuario.Text.Trim(); // no existe en BD, opcional
            string pass = txtPass.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            // Validaciones
            if (string.IsNullOrEmpty(nombre) ||
                string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(pass) ||
                string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    // Verificar si el correo existe
                    string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE Email=@correo";
                    MySqlCommand cmdCheck = new MySqlCommand(checkQuery, con);
                    cmdCheck.Parameters.AddWithValue("@correo", correo);

                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (existe > 0)
                    {
                        MessageBox.Show("Este correo ya está registrado.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insertar usuario
                    string insertQuery = "INSERT INTO usuarios (Nombre, Email, Password) VALUES (@nom, @correo, @pass)";
                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, con);
                    cmdInsert.Parameters.AddWithValue("@nom", nombre);
                    cmdInsert.Parameters.AddWithValue("@correo", correo);
                    cmdInsert.Parameters.AddWithValue("@pass", pass); // si deseas, puedo agregarte hashing

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Owner = this;
            loginForm.Show();
            this.Hide();
        }
    }
}