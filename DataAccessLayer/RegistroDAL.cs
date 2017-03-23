using BusinessEntities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RegistroDAL
    {
        #region Agregar conexión a BD por LINQ y MySQL.
        // Clase contexto que enlaza la Base de Datos por entity framework
        private static IdeaContext db = new IdeaContext();

        public static string CONNECTIONSTRING = "server=localhost;user id=root;pwd=melapelas5225.;persistsecurityinfo=True;database=idea";
        #endregion

        public static bool MandarRegistro(bool tipoRegistro, string matricula)
        {
            //SELECT COUNT (*) FROM Usuario WHERE Matricula = usuario AND Password1 = pass
            //return db.Usuarios.Where(u => u.Matricula == matricula && u.Password1 == pwd).Count() > 0;
            try
            {
                //1. Creamos objeto conexion y le pasamos la cadena de conexión
                //ubicada en el archivo App.Config
                MySqlConnection sqlConn = new MySqlConnection(CONNECTIONSTRING);


                //2. Abrir la conexion
                sqlConn.Open();

                //3. Crear el query que utilizaras
                string query = "INSERT INTO Registro (TipoRegistro, IdUsuario) values (@tipoRegistro, @id)";

                //4° - Crear el objeto comando al cual le pasas el query
                //y la conexion para ejecutar el query antes mencionado
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                int id = UsuarioDAL.obtenerIdUsuario(matricula);

                //5° - Agregar los parametros necesarios
                cmd.Parameters.AddWithValue("@tipoRegistro", tipoRegistro);
                cmd.Parameters.AddWithValue("@Id", id);


                //6° - Ejecutar el query y guardar el resultado
                int rowsAffected = cmd.ExecuteNonQuery();

                //7° - Validar si contiene registros
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
