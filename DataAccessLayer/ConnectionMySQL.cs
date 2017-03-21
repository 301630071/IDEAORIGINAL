using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ConnectionMySQL
    {
        //Declaramos la conexión a la Base de Datos en MySQL
        public static MySqlConnection MySqlConn = new MySqlConnection();
        //Declaramos la cadena de Conexión que utiliza la Base de datos en MySQL.
        public static string ConnectionString = "server=localhost;user id=root; pwd=melapelas5225.;persistsecurityinfo=True;database=idea";

        //Metodo que sirve para iniciar la conexión con MySQL

        public static string iniciarConexion()
        {
            try
            {
                MySqlConn.ConnectionString = ConnectionString;
                MySqlConn.Open();
                return "";
            }
            catch (Exception ex)
            {
                //En caso de haber un error al intentar conectarse a la BD
                //nos enviara un mensaje de error
                return ex.Message;
            }
        }

    }
}
