using MySql.Data.MySqlClient;

namespace GoEats
{
    public class ConexionBD
    {
        private MySqlConnection conexion;

        public ConexionBD()
        {
            conexion = new MySqlConnection("server=localhost; database=goeats; uid=root; pwd=Tsukuyomi19*");
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }
    }
}
