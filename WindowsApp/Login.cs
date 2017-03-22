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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string contraseña = txtPassword.Text.ToString();
            string mensaje = BusinessLogicLayer.UsuarioBLL.iniciarSesion(matricula, contraseña);

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
