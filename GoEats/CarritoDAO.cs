using MySql.Data.MySqlClient;
using System;

namespace GoEats
{
    public class CarritoDAO
    {
        public int ObtenerCarritoActivo(int idUsuario)
        {
            using (var con = new ConexionBD().ObtenerConexion())
            {
                con.Open();
                string qry = "SELECT Id FROM carrito WHERE IdUsuario = @id AND Estado = 'Activo' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                var result = cmd.ExecuteScalar();
                return result == null ? 0 : Convert.ToInt32(result);
            }
        }

        public int CrearCarrito(int idUsuario)
        {
            using (var con = new ConexionBD().ObtenerConexion())
            {
                con.Open();
                string sql = "INSERT INTO carrito (IdUsuario, Estado) VALUES (@usu, 'Activo')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usu", idUsuario);
                cmd.ExecuteNonQuery();
                return (int)cmd.LastInsertedId;
            }
        }

        public void CerrarCarrito(int idCarrito)
        {
            using (var con = new ConexionBD().ObtenerConexion())
            {
                con.Open();
                string sql = "UPDATE carrito SET Estado = 'Finalizado' WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idCarrito);
                cmd.ExecuteNonQuery();
            }
        }
    }
}