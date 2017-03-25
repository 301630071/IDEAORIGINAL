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
    public partial class VenAdminP : Form
    {
        public VenAdminP()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAgregar add = new AdminAgregar();
            add.Show();
        }

        private void matrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarRegistro bus = new BuscarRegistro();
            bus.Show();
        }

        private void porAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAl con = new ConsultarAl();
            con.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarRegistro mr = new ModificarRegistro();
            mr.Show();
        }
    }
}
