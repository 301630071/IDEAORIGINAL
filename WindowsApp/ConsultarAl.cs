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
    #region Consultar Alumno
    public partial class ConsultarAl : Form
    {
        public ConsultarAl()
        {
            InitializeComponent();
        }

        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text;
            DataTable mensaje = BusinessLogicLayer.UsuarioBLL.ConsultarHistorial(u);
            dgbMostrar.DataSource = mensaje;
        }
        #endregion


    }
    #endregion
}
