using Linck.Controller;
using Linck.Data;
using Linck.Service;
using Microsoft.EntityFrameworkCore;
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

namespace Linck
{

   
    public partial class AgregarUser : Form
    {

        public string[] DatosAntiguos;
        public AgregarUser()
        {
            InitializeComponent();

            DatosAntiguos = new string[] { txtNombre.Text, txtGmail.Text, txtContra.Text, txtConfirmarContra.Text };
        }

       


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var UsuarioService = new UsuarioService(); // Configurar los servicios
            var userController = new UserController(UsuarioService); // Inyectar en controladores

            if (validadTexbox())
            {
                if (txtContra.Text.Trim() == txtConfirmarContra.Text.Trim())
                {

                    if (Pictu_user.Image != Linck.Properties.Resources.forr)
                    {
                        userController.NuevoUser(txtNombre.Text, txtContra.Text, txtGmail.Text, Pictu_user); // envia los datos necesarios al controlador
                        int? UserId = userController.IniciarSecion(txtGmail.Text, txtContra.Text)?.Id; // se adquiere el id del usuario que inicia seccion

                        if (UserId != null)
                        {
                            this.Close();

                        }


                    }
                    else
                    {

                        MessageBox.Show("Ingresa una imagen para tu perfil", " ---ERROR--- ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else { MessageBox.Show("La contraseña no coinciden", " ---ERROR--- ", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        }
        public bool validadTexbox()
        {
            string[] DatosActual = { txtNombre.Text, txtGmail.Text, txtContra.Text, txtConfirmarContra.Text };

            for (int i = 0; i < DatosActual.Length; i++)
            {
                if (DatosAntiguos[i] == DatosActual[i])
                {
                    MessageBox.Show("Debe rellenar todos los campos para poder crear el usuario","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; break;
                }
            }

            return true;


        }


        private void btnAgrgarFoto_Click(object sender, EventArgs e)
        {
            // podrá poner imagenes ya sea con extencion PNG o JPG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

            //Al seleccionar una imagen y presionar aceptar ésta se mostrará en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pictu_user.ImageLocation = openFileDialog.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Pictu_user_Click(object sender, EventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "Nombre")            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;


            }

        }



        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

            if (txtNombre.Text.Trim() == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;


            }
        }

        private void txtGmail_Enter(object sender, EventArgs e)
        {
            if (txtGmail.Text.Trim() == "Gmail")
            {
                txtGmail.Text = "";
                txtGmail.ForeColor = Color.Black;

            }

        }

        private void txtGmail_Leave(object sender, EventArgs e)
        {
            if (txtGmail.Text.Trim() == "")
            {
                txtGmail.Text = "Gmail";
                txtGmail.ForeColor = Color.Silver;

            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim() == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;

            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim() == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.Silver;

            }
        }

        private void txtConfirmarContra_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContra.Text.Trim() == "Confirmar contraseña")
            {
                txtConfirmarContra.Text = "";
                txtConfirmarContra.ForeColor = Color.Black;

            }
        }

        private void txtConfirmarContra_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContra.Text.Trim() == "")
            {
                txtConfirmarContra.Text = "Confirmar contraseña";
                txtConfirmarContra.ForeColor = Color.Silver;

            }
        }
    }
}
