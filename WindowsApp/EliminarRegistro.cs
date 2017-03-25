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
    public partial class EliminarRegistro : Form
    {
        public EliminarRegistro()
        {
            InitializeComponent();
        }
        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text;
            u.Estado = 1;
            DataTable mensaje = BusinessLogicLayer.UsuarioBLL.ConsultarAlumno(u);
            dgvMostrar.DataSource = mensaje;
        }
        #endregion

        #region Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Estado = 0;

            string mensaje = BusinessLogicLayer.UsuarioBLL.Eliminar(u);

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("El Usuario ha sido Eliminado");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        #endregion
    }
}

