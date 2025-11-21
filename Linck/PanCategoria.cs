using Linck.Controller;
using Linck.Modelos;
using Linck.Service;
using Linck.Service.Interface;
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
    public partial class PanCategoria : Form
    {
        public int? id_user;
        public string nombreboved;
        public int numeroCategoria;

        public PanCategoria(int? id_user, string nombreboveda)
        {
            InitializeComponent();

            this.id_user = id_user;
            this.nombreboved = nombreboveda;
            numeroCategoria = 0;
            mostrarCategoriaCreadas();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(faceboock.Text)?.Id;
            int? idUsuario = CategoriaControl.obtenerCualquierDato(faceboock.Text)?.NumeroCategoria;


            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, idUsuario ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();



        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(Noticias.Text)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(nombreboved)?.Id;           
            int? userAsociado = CategoriaControl.obtenerCualquierDato(Noticias.Text)?.NumeroCategoria;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, userAsociado ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(deprotes.Text)?.Id;
            int? userAsociado = CategoriaControl.obtenerCualquierDato(deprotes.Text)?.NumeroCategoria;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, userAsociado ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void PanCategoria_Load(object sender, EventArgs e)
        {


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(Favorito.Text)?.Id;
            int? userAsociado = CategoriaControl.obtenerCualquierDato(Favorito.Text)?.NumeroCategoria;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, userAsociado ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

          
            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(documentacion.Text)?.Id;
            int? userAsociado = CategoriaControl.obtenerCualquierDato(documentacion.Text)?.NumeroCategoria;


            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, userAsociado ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void RegresarBT_Click(object sender, EventArgs e)
        {
            Pantalla pan = new Pantalla(id_user, null);
            pan.Show();
            this.Close();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void PanelPredeterminado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconAgregar_Categoria_Click(object sender, EventArgs e)
        {
            NuevaCat cat = new NuevaCat(id_user.Value);
            cat.Show();
        }

        private void mostrarCategoriaCreadas()
        {
            var categoriaService = new CategoriaService();
            var categoriaController = new CategoriaController(categoriaService);
            ocultar_panel();
           


            numeroCategoria = categoriaController.contardorUser(id_user.Value);
          
            if (numeroCategoria > 0 && numeroCategoria < 4)
            {
                var nombreCategoria = categoriaController.ObtenerListaLinksEspesifico(id_user.Value);
              
                int contado = 1; iconButton9.Visible = Visible;
                foreach (var nombre in nombreCategoria)
                {

                    if (contado == 1)
                    {
                        pane1.Visible = true;
                        ico1.Text = nombre.nombre_Categoria;
                        byte[] imageCategoria = categoriaController.obtenerCualquierDato(ico1.Text)?.ImagenUser;
                        using MemoryStream msh = new MemoryStream(imageCategoria);
                        pictIcono.Image = Image.FromStream(msh);
                    }

                    else if (contado == 2)
                    {
                        pane2.Visible = true;
                        ico2.Text = nombre.nombre_Categoria;
                        byte[] imageCategoria = categoriaController.obtenerCualquierDato(ico2.Text)?.ImagenUser;
                        using MemoryStream msh = new MemoryStream(imageCategoria);
                        pict2.Image = Image.FromStream(msh);

                    }
                    else if (contado == 3)
                    {
                        pane3.Visible = true;
                        icon3.Text = nombre.nombre_Categoria;
                        byte[] imageCategoria = categoriaController.obtenerCualquierDato(icon3.Text)?.ImagenUser;
                        using MemoryStream msh = new MemoryStream(imageCategoria);
                        pict3.Image = Image.FromStream(msh);


                    } 

                    contado++;
                }
              




            }



          
        }

        public void ocultar_panel() {

            pane1.Visible = false; pane2.Visible = false; pane3.Visible = false; 

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarCategoriaCreadas();

        }

        private int mostrarNuevasCategoria(int numeroCategoria)
        {

            return numeroCategoria;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            EditCate cate = new EditCate(id_user);
            cate.Show();
        }

        private void icon3_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            if (icon3.Visible)
            {
                int? idCategoria = CategoriaControl.identCAtegoria(id_user.Value, icon3.Text.Trim())?.Id;
                int? idBoveda = BovedaControl.IdentBoveda(id_user.Value, nombreboved)?.id;


                Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

                this.Hide();

                verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();

            }
        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(tutorial.Name)?.Id;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void tecnologia_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(tecnologia.Name)?.Id;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void proyecto_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            int? idBoveda = BovedaControl.obtenerCualquierDato(nombreboved)?.id;
            int? idCategoria = CategoriaControl.obtenerCualquierDato(proyecto.Name)?.Id;

            Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

            this.Hide();

            verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();
        }

        private void ico1_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

       
                int? idCategoria = CategoriaControl.identCAtegoria(id_user.Value, ico1.Text.Trim())?.Id;
                int? idBoveda = BovedaControl.IdentBoveda(id_user.Value, nombreboved)?.id;


                Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

                this.Hide();

                verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();



        }

        private void ico2_Click(object sender, EventArgs e)
        {
            var Boveda = new BovedaService();
            var categoria = new CategoriaService();

            var BovedaControl = new BovedaController(Boveda);
            var CategoriaControl = new CategoriaController(categoria);

            if (ico2.Visible)
            {
                int? idCategoria = CategoriaControl.identCAtegoria(id_user.Value, ico2.Text.Trim())?.Id;
                int? idBoveda = BovedaControl.IdentBoveda(id_user.Value, nombreboved)?.id;


                Visualizacion_lick verLink = new Visualizacion_lick(idBoveda ?? 0, idCategoria ?? 0, id_user ?? 0);

                this.Hide();

                verLink.FormClosed += (s, args) => { this.Show(); }; verLink.Show();

            }
        }
    }
}
