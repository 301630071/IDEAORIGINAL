using BusinessEntities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsuarioDAL
    {
        #region Agregar conexión a BD por LINQ y MySQL.
        // Clase contexto que enlaza la Base de Datos por entity framework
        private static IdeaContext db = new IdeaContext();

        public static string CONNECTIONSTRING = "server=localhost;user id=root;pwd=melapelas5225.;persistsecurityinfo=True;database=idea";
        #endregion


        #region iniciarSesion
        public static bool iniciarSesion(string matricula, string pwd)
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
                string query = "SELECT * FROM Usuario WHERE Matricula = @matricula AND Password1 = @password";

                //4° - Crear el objeto comando al cual le pasas el query
                //y la conexion para ejecutar el query antes mencionado
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                //5° - Agregar los parametros necesarios
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@password", pwd);

                //6° - Ejecutar el query y guardar el resultado
                MySqlDataReader dr = cmd.ExecuteReader();

                //7° - Validar si contiene registros
                if (dr.HasRows)
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
        #endregion


        #region Registrar
        public static bool Registrar(Usuario u)
        {
            try
            {
                //1. Creamos objeto conexion y le pasamos la cadena de conexión
                //ubicada en el archivo App.Config
                MySqlConnection sqlConn = new MySqlConnection(CONNECTIONSTRING);


                //2. Abrir la conexion
                sqlConn.Open();

                //3. Crear el query que utilizaras
                string query = "INSERT INTO Usuario (Matricula, Nombre, Apellido1, Apellido2, IdCarrera, Grado, Password1, Password2, Correo) VALUES (@matricula, @nombre, @apellidoP, @apellidoM, @carrera, @grado, @password1, @password2, @correo )";

                //4° - Crear el objeto comando al cual le pasas el query
                //y la conexion para ejecutar el query antes mencionado
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);

                //5° - Agregar los parametros necesarios
                cmd.Parameters.AddWithValue("@matricula", u.Matricula);
                cmd.Parameters.AddWithValue("@nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@apellidoP", u.Apellido1);
                cmd.Parameters.AddWithValue("@apellidoM", u.Apellido2);
                cmd.Parameters.AddWithValue("@carrera", u.IdCarrera);
                cmd.Parameters.AddWithValue("@grado", u.Grado);
                cmd.Parameters.AddWithValue("@password1", u.Password1);
                cmd.Parameters.AddWithValue("@password2", u.Password2);
                cmd.Parameters.AddWithValue("@correo", u.Correo);

                //6° - Ejecutar el query y guardar el resultado
                int ENQ = cmd.ExecuteNonQuery();

                //7° - Validar si contiene registros
                if (ENQ > 0)
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
    #endregion

}

