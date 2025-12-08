using MySql.Data.MySqlClient;
using System;

namespace GoEats
{
    public class PedidoDAO
    {
        public int CrearPedido(int idUsuario, decimal total)
        {
            int idGenerado = 0;

            ConexionBD bd = new ConexionBD();
            using (MySqlConnection con = bd.ObtenerConexion())
            {
                con.Open();
                string sql = @"INSERT INTO Pedidos (IdUsuario, Total) 
                               VALUES (@u, @t);
                               SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@u", idUsuario);
                cmd.Parameters.AddWithValue("@t", total);

                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return idGenerado;
        }
    }
}