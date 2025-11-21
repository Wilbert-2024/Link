using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Linck.Controller;
using Linck.Service;


namespace Linck
{
    public partial class Link : Form
    {
        int? idusuario;
        public Link(int? iduserr)
        {
            InitializeComponent();

            idusuario = iduserr;

            insertarCategoria();
        }

        private void insertarCategoria()
        {
            pictImagen.Image = Linck.Properties.Resources._2Link;


            var categoria = new CategoriaService();
            var Boveda = new BovedaService(); // hacemos una instacia a la clase UserService
            var Categoriacontroller = new CategoriaController(categoria);// Inyectar en controladores
            var Bovedacontroller = new BovedaController(Boveda);// Inyectar en controladores


            string[] nombresCategorias = Categoriacontroller.ObtenerNombresCategorias();
            string[] nombreBoveda = Bovedacontroller.ObtenerNombresBovedas(idusuario.Value);


            CBCategoria.Items.Clear();
            CBBoveda.Items.Clear();

            CBCategoria.Items.Add("Seleccionar");
            CBBoveda.Items.Add("Seleccinar");


            foreach (var nombreCa in nombresCategorias) { CBCategoria.Items.Add(nombreCa); }
            foreach (var nombreBo in nombreBoveda) { CBBoveda.Items.Add(nombreBo); }

            CBCategoria.SelectedIndex = 0;
            CBBoveda.SelectedIndex = 0;


        }

        private void Link_Load(object sender, EventArgs e)
        {

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegresarBT_Click(object sender, EventArgs e)
        {
            Pantalla pan = new Pantalla(null,null);
            pan.Show();
            this.Close();

        }

        private void txt_ingrese_link_Enter(object sender, EventArgs e)
        {
            BorraMensaje(txt_ingrese_link, "Ingresar link");
        }

        private void txt_ingrese_link_Leave(object sender, EventArgs e)
        {
            MostrarMensaje(txt_ingrese_link, "Ingresar link");

        }

        private void txt_nombre_link_Enter(object sender, EventArgs e)
        {
            BorraMensaje(txt_nombre_link, "Nombre");

        }

        private void txt_nombre_link_Leave(object sender, EventArgs e)
        {
            MostrarMensaje(txt_nombre_link, "Nombre");


        }

        private void BorraMensaje(TextBox txtLink, string Mensaje)
        {
            if (txtLink.Text == Mensaje)
            {
                txtLink.Text = "";

            }
        }

        private void MostrarMensaje(TextBox txtNombres, string Mensaje)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                txtNombres.Text = Mensaje;


            }
        }

        private void btn_Agregar_Link_Click(object sender, EventArgs e)
        {
            var LinkService = new LinkService();
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();
            var LinkController = new LinkController(LinkService);
            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            if (CBCategoria.SelectedItem.ToString() != "Seleccionar")
            {
                int? id_Boveda = 0;
                int? id_categoria = CategoriaControl.obtenerCualquierDato(CBCategoria.SelectedItem.ToString())?.Id;

                if (CBBoveda.SelectedItem.ToString() != "Seleccionar")
                {
                    id_Boveda = BovedaControl.obtenerCualquierDato(CBBoveda.SelectedItem.ToString())?.id;


                    LinkController.AgregarLink(txt_nombre_link.Text.Trim(), txt_ingrese_link.Text.Trim(), pictImagen, id_Boveda.Value, id_categoria.Value);
                    insertarCategoria();
                    this.Close();

                }




            }
            else
            {

               MessageBox.Show("Debe seleccionar una categoria y una boveda ... ");

            }



        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            // podrá poner imagenes ya sea con extencion PNG o JPG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

            //Al seleccionar una imagen y presionar aceptar ésta se mostrará en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictImagen.ImageLocation = openFileDialog.FileName;
            }
        }

        private void CBBoveda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
