using FontAwesome.Sharp;
using Linck.Controller;
using Linck.Data;
using Linck.Modelos;
using Linck.Service;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Runtime.InteropServices;
using System.Windows.Forms.VisualStyles;

namespace Linck
{
    public partial class Pantalla : Form
    {
        public int? idUsusario;
        public string bovedas;
        public Pantalla(int? IDUSer, string Boveda)
        {
            InitializeComponent();
            idUsusario = IDUSer;
            bovedas = Boveda;
            ImagenUSer(idUsusario);
            AgregarCategoriaPermanetes();
            txtBoveda.Text = Boveda;
          


        }
        public void AgregarCategoriaPermanetes()
        {

            var categoria = new CategoriaService();
            var Categoriacontroller = new CategoriaController(categoria);
            CBBoveda.Visible = false;

            string[] Categoria = { "Redes sociales", "Noticias", "Favoritos", "Tutorial", "Deporte", "Tecnologia", "Proyecto", "Documentacio" };

            foreach (var nombre in Categoria)
            {
                if (!Categoriacontroller.ExisteCategoria(nombre)) { Categoriacontroller.CategoriaPermanentes(nombre); }
            }

        }

        public void ImagenUSer(int? iduser)
        {

            var user = new UsuarioService(); // hacemos una instacia a la clase UserService
            var userController = new UserController(user);// Inyectar en controladores
            var imagen = userController.ObtenerImagenUsuario(iduser);

            if (imagen != null) { PictureImagenUser.Image = imagen; }


        }



        // Para poder mover toda la interfaz
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        public void AbrirFormularioEnPanel(Form formHijo)
        {

            // Remueve cualquier formulario hijo existente en panel2
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);

            // Configura el formulario hijo para que se ajuste al panel
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(formHijo);
            this.panel2.Tag = formHijo;
              formHijo.Show();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Link tr = new Link(idUsusario);
            tr.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            MinimumSize = new Size();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {


            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MenuBT_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Menu (idUsusario));
        }

        private void AgregarBT_Click(object sender, EventArgs e)
        {
            Link lin = new Link(idUsusario);
            lin.Show();

        }


        private void PersonalizarBT_Click(object sender, EventArgs e)
        {

        }

        private void CategoriaBT_Click(object sender, EventArgs e)
        {
                    AbrirFormularioEnPanel(new PanCategoria(idUsusario, txtBoveda.Text.Trim()));
         

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Encabezado1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IniciarUser iniciar = new IniciarUser();
            iniciar.Show();
            this.Close();

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            Application.Restart();


        }

        private void BTNMostrarUser_Click(object sender, EventArgs e)
        {
            InterUser listauser = new InterUser(idUsusario);
            listauser.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           // ingresarNombresBoveda();
            InterBodega opcionesBovedas = new InterBodega(idUsusario.Value);
            opcionesBovedas.Show();
            this.Close();

        }

        private void CBBoveda_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CBBoveda.Text == "Nueva Boveda") {
                int idUsuarios = idUsusario.Value;
                InterBodega bo = new InterBodega(idUsuarios);
                bo.Show();
            }
            else if (CBBoveda.Text == "Seleccionar") 
            {

            } else { txtBoveda.Text = CBBoveda.Text; }


        }

        public void ingresarNombresBoveda ()
        {
            CBBoveda.Items.Clear();
            CBBoveda.Visible = true;
            var boveda = new BovedaService();
            var bovedaController = new BovedaController(boveda);

            string[] nombreBoveda = bovedaController.ObtenerNombresBovedas(idUsusario.Value);
          
            CBBoveda.Items.Add("Seleccionar");
            CBBoveda.Items.Add("Nueva Boveda");

            foreach ( var nombre in nombreBoveda) { CBBoveda.Items.Add(nombre); }
            CBBoveda.SelectedIndex = 0;
        }
    }
}
