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
    public partial class InterBodega : Form
    {
        private int id_User;
        public InterBodega(int idUser)
        {
            InitializeComponent();
            id_User = idUser;

            this.Size = new System.Drawing.Size(288, 300);
            Accionar_Iniciar();
            ingresarNombresBoveda();
            button1.Enabled = false;



        }
  

        public void Accionar_Iniciar()
        {
            PanMisbovedas.Visible = false;
            PanAñadir.Visible = false;
            PanEditar.Visible = false;
            PanOpciones.Visible = true;


        }

        public void AccinarMisBovedas()
        {

            PanAñadir.Visible = false;
            PanEditar.Visible = false;
            PanOpciones.Visible = false;
            PanMisbovedas.Visible = true;
        }

        public void Accionar_Anadir()
        {
            PanOpciones.Visible = false;
            PanMisbovedas.Visible = false;
            PanEditar.Visible = false;
            PanAñadir.Visible = true;
        }

        public void Accionar_Editar()
        {
            PanOpciones.Visible = false;
            PanMisbovedas.Visible = false;
            PanAñadir.Visible = false;
            PanEditar.Visible = true;
        }

        public void ingresarNombresBoveda()
        {
            CBMisbovedas.Items.Clear();
            CBMisbovedas.Visible = true;

            var boveda = new BovedaService();
            var bovedaController = new BovedaController(boveda);

            string[] nombreBoveda = bovedaController.ObtenerNombresBovedas(id_User);

            CBMisbovedas.Items.Add("Seleccionar");

            foreach (var nombre in nombreBoveda) { CBMisbovedas.Items.Add(nombre); }
            CBMisbovedas.SelectedIndex = 0;
        }



        private void InterBodega_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var baveda = new BovedaService(); // hacemos una instacia a la clase UserService
            var bovedacontroller = new BovedaController(baveda);// Inyectar en controladores

            if (!string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                bovedacontroller.AgregarBOVEDA(txtNombre.Text.Trim(), id_User, "");
            }
            else
            {

                MessageBox.Show("Debe escribir un nombres de boveda", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            var baveda = new BovedaService(); // hacemos una instacia a la clase UserService
            var bovedacontroller = new BovedaController(baveda);// Inyectar en controladores
            string contrase = bovedacontroller.ObtenerDatos(txtNombre.Text.Trim())?.contrasena;
            string Nombre_categoria = bovedacontroller.ObtenerDatos(txtNombre.Text.Trim())?.nombre_boveda;

            //if (txtContra.Text.Trim() == contrase && txtNombre.Text.Trim() == Nombre_categoria)
            //{
            //    txtNuevoNOmbre.Text = Nombre_categoria;
            //    txtNuevoPassword.Text = contrase;

            //}
            //else
            //{

            //    MessageBox.Show("Las contraseña o el nombre no existen", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            var baveda = new BovedaService(); // hacemos una instacia a la clase UserService
            var bovedacontroller = new BovedaController(baveda);// Inyectar en controladores

            if (!string.IsNullOrWhiteSpace(txtNuevoNOmbre.Text.Trim()) && !string.IsNullOrWhiteSpace(CBMisbovedas.Text))
            {
                bovedacontroller.ActualizarBoveda(CBMisbovedas.Text, txtNombre.Text.Trim());
            }
            else
            {

                MessageBox.Show("Rellenar todos los campos", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

        }

        private void btNuevABOveda_Click(object sender, EventArgs e)
        {
            Accionar_Anadir();

        }

        private void btnMisBovedas_Click(object sender, EventArgs e)
        {
            AccinarMisBovedas();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Accionar_Editar(); lbNombreboveda.Text = CBMisbovedas.Text;
        }

        private void CBMisbovedas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CBMisbovedas.Text == "Seleccionar")
            {
                button1.Enabled = false;

            }
            else { button1.Enabled = true;  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla pantalla = new Pantalla(id_User, CBMisbovedas.Text);
             pantalla.Show();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var baveda = new BovedaService(); // hacemos una instacia a la clase UserService
            var bovedacontroller = new BovedaController(baveda);// Inyectar en controladores
            string contrase = bovedacontroller.ObtenerDatos(txtNombre.Text.Trim())?.contrasena;
            string Nombre_categoria = bovedacontroller.ObtenerDatos(txtNombre.Text.Trim())?.nombre_boveda;

            if (CBMisbovedas.Text.Trim() != "Seleccionar")
            {
                bovedacontroller.EliminarCategoria(CBMisbovedas.Text);

            }
            else
            {
                MessageBox.Show("Boveda no encontrada", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
