using Linck.Controller;
using Linck.Migrations;
using Linck.Modelos;
using Linck.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linck
{
    public partial class EditCate : Form
    {
        private int? isusuario;
        private string NombreCategoria;
        public EditCate(int? IDUSER)
        {
            this.isusuario = IDUSER;

            InitializeComponent();

            insertarCategoria();
        }

        private void insertarCategoria()
        {

            var categoria = new CategoriaService();
            var Categoriacontroller = new CategoriaController(categoria);// Inyectar en controladores
            string? nombresCate;

            CBCategoria.Items.Clear();

            txtNuevCategoria.Enabled = false;
            txtNuevCategoria.Text = "";

            CBCategoria.Items.Add("Seleccionar");

            pictCategoria.Image = null;

            int numeroCategoria = Categoriacontroller.contardorUser(isusuario.Value);


            if ( numeroCategoria < 4)
            {
                var nombreCategoria = Categoriacontroller.ObtenerListaLinksEspesifico(isusuario.Value);

                
                foreach (var nombre in nombreCategoria)
                {
                    CBCategoria.Items.Add(nombre.nombre_Categoria);
                } 
                  
        

            }
            CBCategoria.SelectedIndex = 0;
           



        }

      

        private void EditCate_Load(object sender, EventArgs e)
        {

        }

        private void txtNuevCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictCategoria_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTbuscar_Click(object sender, EventArgs e)
        {

        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            if (CBCategoria.Text != "Seleccionar")
            {
                var categoria = new CategoriaService(); // hacemos una instacia a la clase UserService
                var categoriaController = new CategoriaController(categoria);// Inyectar en controladores

                categoriaController.EliminarCategoria(txtNuevCategoria.Text.Trim());
                this.Close();
            }
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTEditar_Click(object sender, EventArgs e)
        {
            var categoria = new CategoriaService(); // hacemos una instacia a la clase UserService
            var categoriaController = new CategoriaController(categoria);// Inyectar en controladores

            if (!string.IsNullOrWhiteSpace(txtNuevCategoria.Text.Trim())) {
                categoriaController.ActualizarCategoria(CBCategoria.Text, txtNuevCategoria.Text.Trim(), pictCategoria);
                this.Close();
            } else { MessageBox.Show("ingrese o seleccione una categoria"); }


        }

        private void CBCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoria = new CategoriaService(); 
            var categoriaController = new CategoriaController(categoria);

            if (CBCategoria.Text != "Seleccionar")
            {
                byte[] obteneImage = categoriaController.obtenerCualquierDato(CBCategoria.Text)?.ImagenUser;

                using MemoryStream ms = new MemoryStream(obteneImage);
                   

                txtNuevCategoria.Text = CBCategoria.SelectedItem.ToString();
                pictCategoria.Image = Image.FromStream(ms);
                txtNuevCategoria.Enabled = true;
                
            }
            else
            {
                txtNuevCategoria.Enabled = false;
                txtNuevCategoria.Text = "";
                pictCategoria.Image = null;
                
            }
            }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

            //Al seleccionar una imagen y presionar aceptar ésta se mostrará en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictCategoria.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
