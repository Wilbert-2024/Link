using Linck.Controller;
using Linck.Modelos;
using Linck.Service;
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
    public partial class NuevaCat : Form
    {

        public int usuarioID;
        public NuevaCat(int idUser)
        {
            InitializeComponent();         
            usuarioID = idUser;

           
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var Categoria = new CategoriaService(); // Configurar los servicios
            var categoriaController = new CategoriaController(Categoria); // Inyectar en controladores

            // este hace un conteo de las categoria que un usuario ingresa..
            int numeroCategoria = categoriaController.contardorUser(usuarioID);          


            if (numeroCategoria >= 0 && numeroCategoria < 3)
            {               
                categoriaController.AgregarCategoria(txtNuevCategoria.Text.Trim(), pictCategoria, usuarioID);
                //if (!string.IsNullOrWhiteSpace(txtNuevCategoria.Text.Trim()) && pictCategoria != null) {this.Close(); }
            }
            else
            {
                MessageBox.Show("Lo siento pero solo puedes agregar 3 categorias nuevas", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtNuevCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevaCat_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

            //Al seleccionar una imagen y presionar aceptar ésta se mostrará en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictCategoria.ImageLocation = openFileDialog.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
