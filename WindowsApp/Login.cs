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


            txtMatricula.MaxLength = 9;
            txtPassword.MaxLength = 15;

        }


        private void llblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro abrir = new Registro();
            abrir.Show();
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

