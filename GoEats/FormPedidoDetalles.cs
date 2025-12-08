using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GoEats
{
    public partial class FormPedidoDetalles : Form
    {
        private int idPedido;

        public FormPedidoDetalles(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;

            // 🔄 Refrescar datos cuando el formulario ya está visible
            this.Shown += FormPedidoDetalles_Shown;
        }

        private void FormPedidoDetalles_Shown(object sender, EventArgs e)
        {
            CargarDatosPedido();
            CargarProductosPedido();
        }

        private void CargarDatosPedido()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = @"SELECT P.Id,
                                          U.Nombre AS Usuario,
                                          P.Total,
                                          P.Estado,
                                          P.Fecha
                                   FROM Pedidos P
                                   INNER JOIN usuarios U ON U.Id = P.IdUsuario
                                   WHERE P.Id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", idPedido);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblId.Text = $"ID: {dr["Id"]}";
                        lblUsuario.Text = $"Usuario: {dr["Usuario"]}";
                        lblTotal.Text = $"Total: ${dr["Total"]}";
                        lblEstado.Text = $"Estado actual: {dr["Estado"]}";
                        lblFecha.Text = $"Fecha: {dr["Fecha"]}";

                        cmbEstado.SelectedItem = dr["Estado"].ToString();
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del pedido: " + ex.Message);
            }
        }

        private void CargarProductosPedido()
        {
            try
            {
                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = @"SELECT 
                                      m.Nombre AS Producto,
                                      d.Cantidad,
                                      d.PrecioUnitario,
                                      (d.Cantidad * d.PrecioUnitario) AS Subtotal
                                   FROM PedidoDetalles d
                                   INNER JOIN menus m ON m.Id = d.IdMenu
                                   WHERE d.IdPedido = @idPedido";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);

                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);

                    dgvDetalles.DataSource = dt;

                    // Configuración visual
                    dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvDetalles.ReadOnly = true;
                    dgvDetalles.AllowUserToAddRows = false;
                    dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles del pedido: " + ex.Message);
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un estado");
                    return;
                }

                string nuevoEstado = cmbEstado.SelectedItem.ToString();

                ConexionBD bd = new ConexionBD();
                using (MySqlConnection con = bd.ObtenerConexion())
                {
                    con.Open();

                    string sql = @"UPDATE Pedidos 
                                   SET Estado = @est 
                                   WHERE Id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@est", nuevoEstado);
                    cmd.Parameters.AddWithValue("@id", idPedido);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Estado actualizado correctamente");

                // 🔄 Actualizar datos en pantalla
                CargarDatosPedido();
                CargarProductosPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estado: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}