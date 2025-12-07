using MySql.Data.MySqlClient;

namespace GoEats
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        public ConexionBD()
        {
            conexion = new MySqlConnection("server=localhost; database=goeats; uid=root; pwd=");
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
