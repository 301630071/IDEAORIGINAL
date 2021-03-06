﻿using System;
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

            #region Cantidad de Caracteres de los Textbox
            txtMatricula.MaxLength = 9;
            txtPassword.MaxLength = 15;
            #endregion
        }

        #region Link para Registrarse
        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
        }
        #endregion

        #region Boton Entrada
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string contraseña = txtPassword.Text.ToString();
            string mensaje = BusinessLogicLayer.UsuarioBLL.iniciarSesion(matricula, contraseña);
            

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Bienvenido al GYM");

                bool registro = BusinessLogicLayer.RegistroBLL.MandarRegistro(true, matricula);

                if (registro)
                    MessageBox.Show("Exitoso");
                else
                    MessageBox.Show("Fallo");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        #endregion

        #region Bloquear Letras en Cuadro de Texto Matricula
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
        #endregion

        #region Boton Salida
        private void btnSalida_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string contraseña = txtPassword.Text.ToString();
            string mensaje = BusinessLogicLayer.UsuarioBLL.iniciarSesion(matricula, contraseña);


            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("Excelente Trabajo, Sigue así");

                bool registro = BusinessLogicLayer.RegistroBLL.MandarRegistro(false, matricula);

                if (registro)
                    MessageBox.Show("Exitoso");
                else
                    MessageBox.Show("Fallo");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
        #endregion
    }
}

