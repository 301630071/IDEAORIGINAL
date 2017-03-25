using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{

    public class UsuarioBLL
    {
        #region Obtener Id Usuario
        public static int obtenerIdUsuario(string Matricula)
        {
            return DataAccessLayer.UsuarioDAL.obtenerIdUsuario(Matricula);
        }
        #endregion

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
            if (u.Password1 != u.Password2)
            {
                return "Las contraseñas no coinciden";
            }
            if (u.Password1.Length <= 7)
            {
                return "El password debe contener al menos 8 caracteres";
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

        public static string Modificar(Usuario u)
        {
            //Validación 1. 
            //Verificar si el metodo viene con datos
            string msg1 = "Usuario Registrado";


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
            if (string.IsNullOrEmpty(u.Correo))
            {
                return "Falta ingresar el Correo electronico";
            }
            if (u.Password1.Length <= 7)
            {
                return "El password debe contener al menos 8 caracteres";
            }
            else
            {
                string mensaje = "";
                bool conexion = DataAccessLayer.UsuarioDAL.Modificar(u);


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
        #region Consultar
        public static DataTable Consultar(Usuario u)
        {
            string mensaje = "";
            DataTable conexion = DataAccessLayer.UsuarioDAL.Consultar(u);
            return conexion;
        }
        #endregion

        #region Consultar Historial
        public static DataTable ConsultarHistorial(Usuario u)
        {
            string mensaje = "";
            DataTable conexion = DataAccessLayer.UsuarioDAL.ConsultarHistorial(u);
            return conexion;
        }
        #endregion

    }
}