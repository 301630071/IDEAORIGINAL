using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UsuarioBLL
    {
        #region iniciarSesion
        public static string iniciarSesion(string matricula, string pwd)
        {
            //Validación 1. 
            //Verificar si el metodo viene con datos
            if (string.IsNullOrEmpty(matricula))
            {
                return "Falta ingresar la Matricula";
            }

            if (string.IsNullOrEmpty(pwd))
            {
                return "Falta ingresar la contraseña";
            }
            else
            {

                //Validación 2.
                //Verificar conexión con el Servidor
                string msg;

                msg = DataAccessLayer.ConnectionMySQL.iniciarConexion();

                if (string.IsNullOrEmpty(msg))
                {
                    bool IsLogIn;


                    //Conecto DataAccessLayer con BussinessLogicLayer
                    IsLogIn = DataAccessLayer.UsuarioDAL.iniciarSesion(matricula, pwd);


                    //Validación 3. 
                    //Verificar si el usuario existe en la base de datos
                    if (IsLogIn)
                    {
                        return "";
                    }
                    else
                    {
                        return "Favor de intentar nuevamente, credenciales incorrectas";
                    }

                }
                else
                {
                    return msg;
                }
            }

        }
        #endregion
    }
}
