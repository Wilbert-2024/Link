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
    public partial class Menu : Form
    {
        public int? id_user;
        public Menu(int? ID_USER)
        {
            InitializeComponent();
            this.id_user = ID_USER;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
           
        
        }

        private void RegresarBT_Click(object sender, EventArgs e)
        {

            Pantalla pan = new Pantalla(id_user,null);
            pan.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Link link = new Link(id_user);
            link.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            InterBodega bode = new InterBodega(id_user.Value);
            bode.Show();
      
        }


        // Esto me permite llamar la interfaz que quiero abrir dentro de la interfaz principal
    //    private void llamarRegistro()
    //    {

    //        Form2 registra = new Form2();
    //        MenuPrincipal principal = new MenuPrincipal();
    //        AddOwnedForm(registra);
    //        registra.TopLevel = false;
    //        registra.Dock = DockStyle.Fill;
    //        this.Controls.Add(registra);
    //        this.Tag = registra;
    //        registra.BringToFront();
    //        PaNDestino1.Visible = false;
    //        registra.Show();



    //        panel2.Visible = false;
    //        PanelDestino1.Visible = false;
    //        PanelDestino3.Visible = false;
    //        PanelDestino4.Visible = false;

    //    }
   }
}
