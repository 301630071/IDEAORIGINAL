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
            DataTable mensaje = BusinessLogicLayer.UsuarioBLL.Consultar(u);

            //foreach = (por cada fila en mensaje)
            foreach (DataRow row in mensaje.Rows)
            {
                txtResultado.Text = row["Matricula"].ToString();
            }
        }
    }
}
