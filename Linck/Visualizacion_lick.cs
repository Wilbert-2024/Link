using Linck.Controller;
using Linck.Service;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Linck.Migrations;
using System.Windows.Forms;
using Linck.Modelos;
using System.Diagnostics;

namespace Linck
{
    public partial class Visualizacion_lick : Form
    {

        private int idUser, idboveda, idcategoria;
        private int IdUserSelecionado = 0;
        public Visualizacion_lick(int idBoveda, int idCategoria, int idUsuario)
        {
            InitializeComponent();
            idboveda = idBoveda; idcategoria = idCategoria; idUser = idUsuario;
            Mostrarlink();



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            this.SuspendLayout();
        }


        private Panel panelSeleccionado = null;
        private void Mostrarlink()
        {
            Fypanel_lista_LINK.Controls.Clear();
            Fypanel_lista_LINK.FlowDirection = FlowDirection.LeftToRight; // Horizontal
            Fypanel_lista_LINK.WrapContents = true; // Ajuste automático
            Fypanel_lista_LINK.AutoScroll = true;

            var Datoslink = new LinkService();
            var LinkController = new LinkController(Datoslink);

         
            var categoria = new CategoriaService();           
            var CategoriaControl = new CategoriaController(categoria);

            var listaLink = LinkController.ObtenerListaLinksEspesifico(idcategoria, idboveda, idUser);


            foreach (var linkUrl in listaLink)
            {
                if (linkUrl.ImagenLink == null) continue;

                Image image;
                using (MemoryStream ms = new MemoryStream(linkUrl.ImagenLink))
                {
                    image = Image.FromStream(ms);
                }

                System.Windows.Forms.Panel panellink = new System.Windows.Forms.Panel
                {
                    Width = 200,
                    Height = 100,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = linkUrl
                };

                PictureBox picture = new PictureBox
                {
                    Image = image,
                    Width = 80,
                    Height = 80,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10),
                    Tag = linkUrl
                };

                Label lbllink = new Label
                {
                    Text = linkUrl.Nom_link,
                    AutoSize = false,
                    Width = 90,
                    Height = 80,
                    Location = new Point(100, 10),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Tag = linkUrl
                };

                // Asignamos el evento Click
                panellink.Click += Control_Click;
                picture.Click += Control_Click;
                lbllink.Click += Control_Click;

                //
                panellink.DoubleClick += Control_DoubleClick;
                picture.DoubleClick += Control_DoubleClick;
                lbllink.DoubleClick += Control_DoubleClick;


                panellink.Controls.Add(picture);
                panellink.Controls.Add(lbllink);
                Fypanel_lista_LINK.Controls.Add(panellink);


            }

        }


        private void Control_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null)
            {
                Linkss Seleccionado = control.Tag as Linkss;
                if (Seleccionado != null)
                {
                    Panel panelink = (control is Panel) ? control as Panel : control.Parent as Panel;

                    if (panelink != null)
                    {
                        // Restaurar color del panel anterior si es diferente al actual
                        if (panelSeleccionado != null && panelSeleccionado != panelink)
                        {
                            panelSeleccionado.BackColor = Color.FromArgb(0, 64, 64);
                        }

                        // Actualizar selección
                        if (panelSeleccionado != panelink)
                        {
                            IdUserSelecionado = Seleccionado.Id;
                            panelink.BackColor = Color.LightBlue;
                            panelSeleccionado = panelink;


                        }
                    }
                }
            }



        }


        private void Control_DoubleClick(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null)
            {
                Linkss seleccionado = control.Tag as Linkss;
                if (seleccionado != null)
                {
                    // Ahora consultamos el URL desde la base de datos usando el Id
                    var Datoslink = new LinkService();
                    var LinkController = new LinkController(Datoslink);

                    // Supongamos que tienes un método para obtener el registro por ID
                    var linkCompleto = LinkController.optenerdato(seleccionado.Id);

                    if (linkCompleto != null && !string.IsNullOrEmpty(linkCompleto.link))
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = linkCompleto.link,
                                UseShellExecute = true
                            });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el enlace en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            var link = new LinkService();
            var LinkController = new LinkController(link);

            string nombreLink = LinkController.optenerdato(IdUserSelecionado)?.Nom_link;
            LinkController.EliminarLink(nombreLink);
            Mostrarlink();

        }

        private void BTActualizar_Click(object sender, EventArgs e)
        {
            Mostrarlink();
        }

        private void BTEditar_Click(object sender, EventArgs e)
        {
            var Link = new LinkService(); // Configurar los servicios
            var linkCOntrolador = new LinkController(Link);

            if (IdUserSelecionado != 0)
            {               
                string nombreLink = linkCOntrolador.optenerdato(IdUserSelecionado)?.Nom_link;
                string urlLink = linkCOntrolador.optenerdato(IdUserSelecionado)?.link;
             
                using MemoryStream ms = new MemoryStream(linkCOntrolador.optenerdato(IdUserSelecionado)?.ImagenLink);
              

                EditLick editarLink = new EditLick(Image.FromStream(ms), nombreLink,urlLink);
                    editarLink.Show();



            }
            else { MessageBox.Show("Debe seleccionar un USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }



        }
    }
}
