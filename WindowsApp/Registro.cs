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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            

            cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrado.Items.Add("PRIMERO");
            cboGrado.Items.Add("SEGUNDO");
            cboGrado.Items.Add("TERCERO");
            cboGrado.Items.Add("CUARTO");
            cboGrado.Items.Add("QUINTO");
            cboGrado.Items.Add("SEXTO");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Matricula = txtMatricula.Text.ToString();
            u.Nombre = txtNombre.Text.ToString();
            u.Apellido1 = txtApellidoP.Text.ToString();
            u.Apellido2 = txtApellidoM.Text.ToString();
            u.IdCarrera = cboCarrera.SelectedIndex();
            u.Grado = cboGrado.SelectedValue.ToString();
            u.Password1 = txtPassword1.Text.ToString();
            u.Password2 = txtPassword2.Text.ToString();

            //mensaje =

        }
    }
}
