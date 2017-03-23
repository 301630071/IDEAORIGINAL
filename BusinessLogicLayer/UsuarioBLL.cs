using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UsuarioBLL
    {
        public static int obtenerIdUsuario(string Matricula)
        {
            return DataAccessLayer.UsuarioDAL.obtenerIdUsuario(Matricula);
        }

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

        #region Registrar
        public static string Registrar(Usuario u)
        {
            //Validación 1. 
            //Verificar si el metodo viene con datos
            string msg1 = "Usuario Registrado";


            if (string.IsNullOrEmpty(u.Matricula)) 
            {
                return "Falta ingresar la Matricula";
            }
            if (string.IsNullOrEmpty(u.Nombre)) 
            {
                return "Falta ingresar el Nombre";
            }
            if (string.IsNullOrEmpty(u.Apellido1)) 
            {
                return "Falta ingresar el Apellido Paterno";
            }
            if (string.IsNullOrEmpty(u.Apellido2)) 
            {
                return "Falta ingresar el Apellido Materno";
            }
            if (string.IsNullOrEmpty(u.Grado))
            {
                return "Falta seleccionar tu grado";
            }
            if (string.IsNullOrEmpty(u.Password1))
            {
                return "Falta ingresar la contraseña";
            }
            if (string.IsNullOrEmpty(u.Password2))
            {
                return "Falta reingresar la contraseña";
            }
            if (string.IsNullOrEmpty(u.Correo))
            {
                return "Falta ingresar el Correo electronico";
            }
            else
            {
                string mensaje = "";
                bool conexion = DataAccessLayer.UsuarioDAL.Registrar(u);


                if (conexion == true)
                {
                    return "";
                }
                else
                {
                    mensaje = "No se pudo registrar correctamente";
                    return mensaje;
                }

            }
        }
        #endregion
    }
}





