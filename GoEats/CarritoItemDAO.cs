using MySql.Data.MySqlClient;
using System.Data;

namespace GoEats
{
    public class CarritoItemDAO
    {
        public void EliminarItemsDeCarrito(int idCarrito)
        {
            using (var con = new ConexionBD().ObtenerConexion())
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM carrito_items WHERE IdCarrito = @id", con);
                cmd.Parameters.AddWithValue("@id", idCarrito);
                cmd.ExecuteNonQuery();
            }
        }

        public int AgregarItem(int idCarrito, int idMenu, int cantidad, decimal precio)
        {
            using (var conn = new ConexionBD().ObtenerConexion())
            {
                conn.Open();

                string check = "SELECT Id, Cantidad FROM carrito_items WHERE IdCarrito = @car AND IdMenu = @menu LIMIT 1";

                using (var cmd = new MySqlCommand(check, conn))
                {
                    cmd.Parameters.AddWithValue("@car", idCarrito);
                    cmd.Parameters.AddWithValue("@menu", idMenu);

                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            int idItem = rd.GetInt32("Id");
                            int cant = rd.GetInt32("Cantidad");
                            rd.Close();

                            string upd = "UPDATE carrito_items SET Cantidad = @c WHERE Id = @id";
                            using (var cmdup = new MySqlCommand(upd, conn))
                            {
                                cmdup.Parameters.AddWithValue("@c", cant + cantidad);
                                cmdup.Parameters.AddWithValue("@id", idItem);
                                cmdup.ExecuteNonQuery();
                            }
                            return idItem;
                        }
                    }
                }

                string insert =
                    @"INSERT INTO carrito_items (IdCarrito, IdMenu, Cantidad, PrecioUnitario)
                      VALUES (@car, @menu, @cant, @precio)";

                using (var cmd = new MySqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@car", idCarrito);
                    cmd.Parameters.AddWithValue("@menu", idMenu);
                    cmd.Parameters.AddWithValue("@cant", cantidad);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public DataTable ObtenerItems(int idCarrito)
        {
            using (var conn = new ConexionBD().ObtenerConexion())
            {
                conn.Open();
                string query =
                @"SELECT ci.Id, ci.IdMenu, m.Nombre, ci.Cantidad, ci.PrecioUnitario, m.Imagen
                  FROM carrito_items ci
                  INNER JOIN menus m ON ci.IdMenu = m.Id
                  WHERE ci.IdCarrito = @car";

                using (var da = new MySqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@car", idCarrito);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void ActualizarCantidad(int idItem, int nuevaCantidad)
        {
            using (var conn = new ConexionBD().ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE carrito_items SET Cantidad = @c WHERE Id = @id", conn);

                cmd.Parameters.AddWithValue("@c", nuevaCantidad);
                cmd.Parameters.AddWithValue("@id", idItem);
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarItem(int idItem)
        {
            using (var conn = new ConexionBD().ObtenerConexion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM carrito_items WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", idItem);
                cmd.ExecuteNonQuery();
            }
        }
    }
}