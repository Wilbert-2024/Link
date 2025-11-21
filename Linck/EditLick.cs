using Linck.Controller;
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
    public partial class EditLick : Form
    {

        private Image imagenLink;
        private string? nombre_link;
        private string? urlLink;


        public EditLick(Image image, string nombre, string url)
        {
            InitializeComponent();
            imagenLink = image;
            urlLink = url;
            nombre_link = nombre;

            insertarDatosAeditar();

        }

        public void insertarDatosAeditar()
        {
            pic_Imagen.Image = imagenLink;
            txtNombre.Text = nombre_link;
            txtURL.Text = urlLink;


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

        
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               pic_Imagen.ImageLocation = openFileDialog.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditLick_Load(object sender, EventArgs e)
        {

        }

        private void BTConfirmar_Click(object sender, EventArgs e)
        {
            var link = new LinkService();         
            var linkController = new LinkController(link);

            linkController.ActualizarLink(nombre_link,txtNombre.Text, txtURL.Text.Trim(), pic_Imagen );
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
