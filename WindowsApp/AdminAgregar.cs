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
    public partial class AdminAgregar : Form
    {
        public AdminAgregar()
        {
            InitializeComponent();

            #region Combo Carrera BD
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCarrera.DataSource = BusinessLogicLayer.CarreraBLL.cargarComboBox();
            cboCarrera.DisplayMember = "Nombre";
            cboCarrera.ValueMember = "Id";
            #endregion

            #region Combo Grado 
            cboGrado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGrado.Items.Add("PRIMERO");
            cboGrado.Items.Add("SEGUNDO");
            cboGrado.Items.Add("TERCERO");
            cboGrado.Items.Add("CUARTO");
            cboGrado.Items.Add("QUINTO");
            cboGrado.Items.Add("SEXTO");
            #endregion

            #region Cuadros de Texto MaxLength
            txtMatricula.MaxLength = 9;
            txtNombre.MaxLength = 50;
            txtApellidoP.MaxLength = 30;
            txtApellidoM.MaxLength = 30;
            txtPassword1.MaxLength = 15;
            txtPassword2.MaxLength = 15;
            txtCorreo.MaxLength = 30;
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Boton Registrar
            {
                #region  Usuario
                Usuario u = new Usuario();
                u.Matricula = txtMatricula.Text.ToString();
                u.Nombre = txtNombre.Text.ToString();
                u.Apellido1 = txtApellidoP.Text.ToString();
                u.Apellido2 = txtApellidoM.Text.ToString();
                u.IdCarrera = Convert.ToInt32(cboCarrera.SelectedValue.ToString());
                u.Grado = cboGrado.SelectedItem.ToString();
                u.Password1 = txtPassword1.Text.ToString();
                u.Password2 = txtPassword2.Text.ToString();
                u.Correo = txtCorreo.Text.ToString();
                #endregion

                string mensaje = BusinessLogicLayer.UsuarioBLL.Registrar(u);

                if (string.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show("Alumno Registrado Exitosamente");
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            #endregion
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
