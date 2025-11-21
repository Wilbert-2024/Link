using Linck.Controller;
using Linck.Modelos;
using Linck.Service;
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
    public partial class InterUser : Form
    {
        private int? idusuario;
        private int IdUserSelecionado = 0;

        public InterUser(int? idUser)
        {
            idusuario = idUser;

            InitializeComponent();
            MostrarUsuariosEnLista();
            asignarTamanoInterfaz(0);



        }

        // Variable para guardar el panel actualmente seleccionado
        private Panel panelSeleccionado = null;
        private void MostrarUsuariosEnLista()
        {

            Fypanel.Controls.Clear();
            Fypanel.FlowDirection = FlowDirection.TopDown;
            Fypanel.WrapContents = false;
            Fypanel.AutoScroll = true;

            var user = new UsuarioService();
            var userController = new UserController(user);
            var listaUsuarios = userController.ObtenerListaUsuarios();

            foreach (var usuario in listaUsuarios)
            {
                if (usuario.ImagenUser == null) continue;

                Image imagen;
                using (MemoryStream ms = new MemoryStream(usuario.ImagenUser))
                {
                    imagen = Image.FromStream(ms);
                }

                Panel panelUsuario = new Panel
                {
                    Width = Fypanel.ClientSize.Width - 25,
                    Height = 70,
                    Margin = new Padding(5),
                    Tag = usuario

                };

                PictureBox picture = new PictureBox
                {
                    Image = imagen,
                    Width = 50,
                    Height = 50,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(10, 10),
                    Tag = usuario
                };

                Label lblCorreo = new Label
                {
                    Text = usuario.correoElectronico,
                    AutoSize = false,
                    Width = panelUsuario.Width - picture.Width - 30,
                    Height = 70,
                    Location = new Point(picture.Right + 10, 10),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Tag = usuario
                };

                // Asignamos el evento Click
                panelUsuario.Click += Control_Click;
                picture.Click += Control_Click;
                lblCorreo.Click += Control_Click;

                panelUsuario.Controls.Add(picture);
                panelUsuario.Controls.Add(lblCorreo);

                Fypanel.Controls.Add(panelUsuario);
            }
        }





        private void Control_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Tag != null)
            {
                Usuario usuarioSeleccionado = control.Tag as Usuario;
                if (usuarioSeleccionado != null)
                {
                    Panel panelUsuario = (control is Panel) ? (Panel)control : control.Parent as Panel;

                    if (panelUsuario != null)
                    {
                        // Restaurar color del panel anterior si es diferente al actual
                        if (panelSeleccionado != null && panelSeleccionado != panelUsuario)
                        {
                            panelSeleccionado.BackColor = Color.FromArgb(0, 64, 64);
                        }

                        // Actualizar selección
                        if (panelSeleccionado != panelUsuario)
                        {
                            IdUserSelecionado = usuarioSeleccionado.Id;
                            panelUsuario.BackColor = Color.LightBlue;
                            panelSeleccionado = panelUsuario;


                        }
                    }
                }
            }



        }



        private void RegresarBT_Click(object sender, EventArgs e)
        {
            Pantalla pana = new Pantalla(idusuario,null);
            pana.Show();
            this.Hide();
        }

        private void InterUser_Load(object sender, EventArgs e)
        {

        }

        private void InterUser_Load_1(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {



        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void AgregarUserBT_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MostrarUsuariosEnLista();
            PanelEditor.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }




        private void BTagregarFoto_Click(object sender, EventArgs e)
        {

        }

        private void BTEditar_Click_1(object sender, EventArgs e)
        {
            var UsuarioService = new UsuarioService(); // Configurar los servicios
            var UserCOntrolador = new UserController(UsuarioService);

            if (IdUserSelecionado != 0)
            {
                asignarTamanoInterfaz(1);
                txtNombre.Text = UserCOntrolador.obtenerDatos(IdUserSelecionado)?.Nombre;
                TxtGmail.Text = UserCOntrolador.obtenerDatos(IdUserSelecionado)?.correoElectronico;

                using MemoryStream ms = new MemoryStream(UserCOntrolador.obtenerDatos(IdUserSelecionado)?.ImagenUser);
                PicImagen.Image = Image.FromStream(ms);



            }
            else { MessageBox.Show("Debe seleccionar aun USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }





        }

        private void BTActualizar_Click(object sender, EventArgs e)
        {
            MostrarUsuariosEnLista();
        }

        private void BTEliminar_Click(object sender, EventArgs e)
        {
            var UsuarioService = new UsuarioService(); // Configurar los servicios
            var UserCOntrolador = new UserController(UsuarioService);

            if (UserCOntrolador != null) { UserCOntrolador.eliminarUsuario(IdUserSelecionado); MostrarUsuariosEnLista(); }
            else { MessageBox.Show("Debe seleccionar aun USUARIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void AgregarUserBT_Click_1(object sender, EventArgs e)
        {
            AgregarUser agre = new AgregarUser();
            agre.Show();
            this.Hide();

        }

        private void BTagregarFoto_Click_1(object sender, EventArgs e)
        {
            // podrá poner imagenes ya sea con extencion PNG o JPG
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg";

            //Al seleccionar una imagen y presionar aceptar ésta se mostrará en el PictureBox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicImagen.ImageLocation = openFileDialog.FileName;
            }


        }


        public void asignarTamanoInterfaz(int opcion)
        {
            if (opcion == 0)
            {
                this.Size = new System.Drawing.Size(554, 450);
                PanelEditor.Visible = false;
            }
            else
            {
                this.Size = new System.Drawing.Size(800, 450);
                PanelEditor.Visible = true;
            }

        }

        private void BTGuardar_Click(object sender, EventArgs e)
        {
            var UsuarioService = new UsuarioService(); // Configurar los servicios
            var UserCOntrolador = new UserController(UsuarioService);

            UserCOntrolador.ActualizarUsuario(txtNombre.Text.Trim(), TxtGmail.Text.Trim(), txtContras.Text.Trim(), PicImagen, IdUserSelecionado);


        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
