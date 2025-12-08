using MySql.Data.MySqlClient;

namespace GoEats
{
    public class PedidoDetalleDAO
    {
        public void AgregarDetalle(int idPedido, int idMenu, int cantidad, decimal precio)
        {
            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO PedidoDetalles (IdPedido, IdMenu, Cantidad, PrecioUnitario)
                               VALUES (@p, @m, @c, @pr);";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@p", idPedido);
                cmd.Parameters.AddWithValue("@m", idMenu);
                cmd.Parameters.AddWithValue("@c", cantidad);
                cmd.Parameters.AddWithValue("@pr", precio);

                cmd.ExecuteNonQuery();
            }
        }
    }
}