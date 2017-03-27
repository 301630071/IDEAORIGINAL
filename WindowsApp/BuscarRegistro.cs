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
    public partial class BuscarRegistro : Form
    {
        public BuscarRegistro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text;
            u.Estado = 1;

            if (u.Estado == 0)
            {
                MessageBox.Show("No se encontro el Alumno en la Base de Datos");
            }
            DataTable mensaje = BusinessLogicLayer.UsuarioBLL.Consultar(u);

            //foreach = (por cada fila en mensaje)
            foreach (DataRow row in mensaje.Rows)
            {
                txtNombres.Text = row["Nombre"].ToString();
                txtApellido1.Text = row["Apellido1"].ToString();
                txtApellido2.Text = row["Apellido2"].ToString();
                txtCampus.Text = row["IdCampus"].ToString();
                txtCarrera.Text = row["IdCarrera"].ToString();
                txtGrado.Text = row["Grado"].ToString();
                txtPassword1.Text = row["Password1"].ToString();
                txtCorreo.Text = row["Correo"].ToString();
            }
        }
    }
}
