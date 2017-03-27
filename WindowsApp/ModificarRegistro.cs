using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class ModificarRegistro : Form
    {
        public ModificarRegistro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text;
            DataTable mensaje = BusinessLogicLayer.UsuarioBLL.Consultar(u);

            //foreach = (por cada fila en mensaje)
            foreach (DataRow row in mensaje.Rows)
            {
                txtMatriculaR.Text = row["Matricula"].ToString();
                txtNombre.Text = row["Nombre"].ToString();
                txtApellido1.Text = row["Apellido1"].ToString();
                txtApellido2.Text = row["Apellido2"].ToString();
                txtCampus.Text = row["IdCampus"].ToString();
                txtCarrera.Text = row["IdCarrera"].ToString();
                txtGrado.Text = row["Grado"].ToString();
                txtPassword1.Text = row["Password1"].ToString();
                txtCorreo.Text = row["Correo"].ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            #region Mandar a Llamar Usuario de Entidades
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text.ToString();
            u.Nombre = txtNombre.Text.ToString();
            u.Apellido1 = txtApellido1.Text.ToString();
            u.Apellido2 = txtApellido2.Text.ToString();
            u.IdCampus = Convert.ToInt32(txtCampus.Text.ToString());
            u.IdCarrera = Convert.ToInt32(txtCarrera.Text.ToString());
            u.Grado = txtGrado.Text.ToString();
            u.Password1 = txtPassword1.Text.ToString();
            u.Password2 = txtPassword1.Text.ToString();
            u.Correo = txtCorreo.Text.ToString();
            #endregion

            string mensaje = BusinessLogicLayer.UsuarioBLL.Modificar(u);


            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("El alumno ha sido modificado exitosamente");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
