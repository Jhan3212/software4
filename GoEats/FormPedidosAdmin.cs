using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormPedidosAdmin : Form
    {
        public FormPedidosAdmin()
        {
            InitializeComponent();

            // Evento para cargar pedidos siempre que se muestre el form
            this.Shown += FormPedidosAdmin_Shown;
        }

        private void FormPedidosAdmin_Load(object sender, EventArgs e)
        {
            // Seleccionar filtro “Todos” desde el inicio
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void FormPedidosAdmin_Shown(object sender, EventArgs e)
        {
            // Cargar pedidos al entrar en pantalla
            CargarPedidos("Todos");
        }

        private void CargarPedidos(string estado = "Todos")
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = @"SELECT Id, IdUsuario, Total, Estado, Fecha 
                                   FROM Pedidos";

                    if (estado != "Todos")
                    {
                        sql += " WHERE Estado = @estado";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    if (estado != "Todos")
                    {
                        cmd.Parameters.AddWithValue("@estado", estado);
                    }

                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);

                    dgvPedidos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPedidos(cmbFiltroEstado.SelectedItem.ToString());
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPedidos(cmbFiltroEstado.SelectedItem.ToString());
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido");
                return;
            }

            int idPedido = Convert.ToInt32(
                dgvPedidos.SelectedRows[0].Cells["Id"].Value);

            FormPedidoDetalles det = new FormPedidoDetalles(idPedido);
            det.ShowDialog();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}