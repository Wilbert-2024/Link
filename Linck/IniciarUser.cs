using Linck.Controller;
using Linck.Data;
using Linck.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Linck
{
    public partial class IniciarUser : Form
    {
        public IniciarUser()
        {
            InitializeComponent();
            ocultaContraseña();

        }
        private bool passwordVisible = false; // lo creamos para tener control de la imagen de mostrar contraseña
        public int? UserId = null; // se hace una variable para capturar el id de user

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string correo, contrasena;
                var user = new UsuarioService(); // hacemos una instacia a la clase UserService
                var userController = new UserController(user);// Inyectar en controladores
                UserId = userController.IniciarSecion(comparar(TXTUser.Text.Trim()), comparar(txtPasword.Text.Trim()))?.Id; // se adquiere el id del usuario que inicia seccion

                if (UserId != null)
                {
                    Pantalla principal = new Pantalla(UserId,null);
                    principal.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error = " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

       
        }

        public string comparar(string mensaje)
        {
            string datos=mensaje;
            if (TXTUser.Text == "Usuario") {
                datos = "";
            }
            if (txtPasword.Text == "Contraseña")
            { datos = "";  }

            return datos;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void TXTUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBAgregarCorre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AgregarUser agregarUser = new AgregarUser();
            agregarUser.FormClosed += (s, args) => { this.Show(); };
            agregarUser.Show();
        }

        private void TXTUser_Enter(object sender, EventArgs e)
        {
            if (TXTUser.Text == "Usuario")
            {
                TXTUser.Text = "";
                TXTUser.ForeColor = Color.Black;

            }

            if (txtPasword.PasswordChar == '\0') { ocultaContraseña(); }
        }

        void muestraOcultarContraseña()
        {
            
            if (!passwordVisible)
            {
                ocultaContraseña();
                passwordVisible = true;

            } 
            else {
                MostrarPassword.Image = Linck.Properties.Resources._1verContraseña;
                txtPasword.PasswordChar = '\0';
                passwordVisible = false;
            }

        }

        void ocultaContraseña()
        {
            MostrarPassword.Image = Linck.Properties.Resources._2OcultarContra;
            txtPasword.PasswordChar = '*';
        }
        
        private void TXTUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTUser.Text.Trim()))
            {
                TXTUser.Text = "Usuario";
                TXTUser.ForeColor = Color.Silver;

            }
        }

        private void txtPasword_Enter(object sender, EventArgs e)
        {
            if (txtPasword.Text == "Contraseña")
            {
                txtPasword.Text = "";
                txtPasword.ForeColor = Color.Black;

            }

        }

        private void txtPasword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasword.Text.Trim()))
            {
                txtPasword.Text = "Contraseña";
                txtPasword.ForeColor = Color.Silver;

            }
        }

        private void MostrarPassword_Click(object sender, EventArgs e)
        {
            muestraOcultarContraseña();
        }

        private void MostrarPassword_MouseEnter(object sender, EventArgs e)
        {
          //  muestraOcultarContraseña();
        }
    }
}
