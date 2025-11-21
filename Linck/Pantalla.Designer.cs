namespace Linck
{
    partial class Pantalla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
 
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            panel1 = new Panel();
            CBBoveda = new ComboBox();
            BTNMostrarUser = new Button();
            PictureImagenUser = new PictureBox();
            btnEliminarCuenta = new Button();
            BTNCategoria = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            MenuBT = new FontAwesome.Sharp.IconButton();
            PersonalizarBT = new FontAwesome.Sharp.IconButton();
            AgregarBT = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Encabezado1 = new Panel();
            txtBoveda = new TextBox();
            label2 = new Label();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            pictureBox5 = new PictureBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureImagenUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Encabezado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(CBBoveda);
            panel1.Controls.Add(BTNMostrarUser);
            panel1.Controls.Add(PictureImagenUser);
            panel1.Controls.Add(btnEliminarCuenta);
            panel1.Controls.Add(BTNCategoria);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(MenuBT);
            panel1.Controls.Add(PersonalizarBT);
            panel1.Controls.Add(AgregarBT);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 480);
            panel1.TabIndex = 0;
            // 
            // CBBoveda
            // 
            CBBoveda.Cursor = Cursors.Hand;
            CBBoveda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBBoveda.FormattingEnabled = true;
            CBBoveda.Location = new Point(11, 330);
            CBBoveda.Name = "CBBoveda";
            CBBoveda.Size = new Size(150, 24);
            CBBoveda.TabIndex = 0;
            CBBoveda.SelectedIndexChanged += CBBoveda_SelectedIndexChanged;
            // 
            // BTNMostrarUser
            // 
            BTNMostrarUser.BackColor = Color.Black;
            BTNMostrarUser.FlatStyle = FlatStyle.Popup;
            BTNMostrarUser.ForeColor = Color.FromArgb(0, 192, 0);
            BTNMostrarUser.Location = new Point(79, 114);
            BTNMostrarUser.Name = "BTNMostrarUser";
            BTNMostrarUser.Size = new Size(90, 23);
            BTNMostrarUser.TabIndex = 10;
            BTNMostrarUser.Text = "MostrarUser";
            BTNMostrarUser.UseVisualStyleBackColor = false;
            BTNMostrarUser.Click += BTNMostrarUser_Click;
            // 
            // PictureImagenUser
            // 
            PictureImagenUser.BackColor = Color.Black;
            PictureImagenUser.Location = new Point(3, 4);
            PictureImagenUser.Name = "PictureImagenUser";
            PictureImagenUser.Size = new Size(166, 101);
            PictureImagenUser.SizeMode = PictureBoxSizeMode.Zoom;
            PictureImagenUser.TabIndex = 10;
            PictureImagenUser.TabStop = false;
            // 
            // btnEliminarCuenta
            // 
            btnEliminarCuenta.BackColor = Color.Black;
            btnEliminarCuenta.Cursor = Cursors.Hand;
            btnEliminarCuenta.FlatStyle = FlatStyle.Popup;
            btnEliminarCuenta.ForeColor = Color.Red;
            btnEliminarCuenta.Location = new Point(3, 111);
            btnEliminarCuenta.Name = "btnEliminarCuenta";
            btnEliminarCuenta.Size = new Size(70, 28);
            btnEliminarCuenta.TabIndex = 10;
            btnEliminarCuenta.Text = "Salir ";
            btnEliminarCuenta.UseVisualStyleBackColor = false;
            btnEliminarCuenta.Click += btnEliminarCuenta_Click;
            // 
            // BTNCategoria
            // 
            BTNCategoria.Anchor = AnchorStyles.Left;
            BTNCategoria.BackColor = Color.Transparent;
            BTNCategoria.Cursor = Cursors.Hand;
            BTNCategoria.FlatStyle = FlatStyle.Flat;
            BTNCategoria.ForeColor = Color.Green;
            BTNCategoria.IconChar = FontAwesome.Sharp.IconChar.Codepen;
            BTNCategoria.IconColor = Color.DarkGreen;
            BTNCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNCategoria.IconSize = 35;
            BTNCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            BTNCategoria.Location = new Point(11, 284);
            BTNCategoria.Name = "BTNCategoria";
            BTNCategoria.Size = new Size(150, 33);
            BTNCategoria.TabIndex = 12;
            BTNCategoria.Text = "Categorias";
            BTNCategoria.UseVisualStyleBackColor = false;
            BTNCategoria.Click += CategoriaBT_Click;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Vault;
            iconButton3.IconColor = Color.FromArgb(64, 0, 0);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 100;
            iconButton3.Location = new Point(31, 360);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(96, 77);
            iconButton3.TabIndex = 9;
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // MenuBT
            // 
            MenuBT.Anchor = AnchorStyles.Left;
            MenuBT.BackColor = Color.Transparent;
            MenuBT.Cursor = Cursors.Hand;
            MenuBT.FlatStyle = FlatStyle.Flat;
            MenuBT.ForeColor = Color.FromArgb(128, 255, 255);
            MenuBT.IconChar = FontAwesome.Sharp.IconChar.FileText;
            MenuBT.IconColor = Color.FromArgb(0, 192, 192);
            MenuBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuBT.IconSize = 35;
            MenuBT.ImageAlign = ContentAlignment.MiddleLeft;
            MenuBT.Location = new Point(11, 164);
            MenuBT.Name = "MenuBT";
            MenuBT.Size = new Size(150, 33);
            MenuBT.TabIndex = 11;
            MenuBT.Text = "Menu";
            MenuBT.UseVisualStyleBackColor = false;
            MenuBT.Click += MenuBT_Click;
            // 
            // PersonalizarBT
            // 
            PersonalizarBT.Anchor = AnchorStyles.Left;
            PersonalizarBT.BackColor = Color.Transparent;
            PersonalizarBT.Cursor = Cursors.Hand;
            PersonalizarBT.FlatStyle = FlatStyle.Flat;
            PersonalizarBT.ForeColor = Color.FromArgb(128, 255, 128);
            PersonalizarBT.IconChar = FontAwesome.Sharp.IconChar.WandMagicSparkles;
            PersonalizarBT.IconColor = Color.Lime;
            PersonalizarBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PersonalizarBT.IconSize = 35;
            PersonalizarBT.ImageAlign = ContentAlignment.MiddleLeft;
            PersonalizarBT.Location = new Point(11, 245);
            PersonalizarBT.Name = "PersonalizarBT";
            PersonalizarBT.Size = new Size(150, 33);
            PersonalizarBT.TabIndex = 10;
            PersonalizarBT.Text = "Personalizar";
            PersonalizarBT.UseVisualStyleBackColor = false;
            PersonalizarBT.Click += PersonalizarBT_Click;
            // 
            // AgregarBT
            // 
            AgregarBT.Anchor = AnchorStyles.Left;
            AgregarBT.BackColor = Color.Transparent;
            AgregarBT.Cursor = Cursors.Hand;
            AgregarBT.FlatStyle = FlatStyle.Flat;
            AgregarBT.ForeColor = Color.FromArgb(128, 255, 255);
            AgregarBT.IconChar = FontAwesome.Sharp.IconChar.Chain;
            AgregarBT.IconColor = Color.Cyan;
            AgregarBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarBT.IconSize = 35;
            AgregarBT.ImageAlign = ContentAlignment.MiddleLeft;
            AgregarBT.Location = new Point(11, 203);
            AgregarBT.Name = "AgregarBT";
            AgregarBT.Size = new Size(150, 33);
            AgregarBT.TabIndex = 9;
            AgregarBT.Text = "Agregar";
            AgregarBT.UseVisualStyleBackColor = false;
            AgregarBT.Click += AgregarBT_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(64, 0, 0);
            button3.Location = new Point(31, 439);
            button3.Name = "button3";
            button3.Size = new Size(115, 25);
            button3.TabIndex = 5;
            button3.Text = "Bodega";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.foto;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(193, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 185);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // Encabezado1
            // 
            Encabezado1.BackColor = Color.Black;
            Encabezado1.BorderStyle = BorderStyle.FixedSingle;
            Encabezado1.Controls.Add(txtBoveda);
            Encabezado1.Controls.Add(label2);
            Encabezado1.Controls.Add(iconButton6);
            Encabezado1.Controls.Add(pictureBox5);
            Encabezado1.Controls.Add(iconButton4);
            Encabezado1.Dock = DockStyle.Top;
            Encabezado1.Location = new Point(174, 0);
            Encabezado1.Name = "Encabezado1";
            Encabezado1.Size = new Size(626, 86);
            Encabezado1.TabIndex = 6;
            Encabezado1.MouseDown += Encabezado1_MouseDown;
            // 
            // txtBoveda
            // 
            txtBoveda.Enabled = false;
            txtBoveda.Location = new Point(229, 58);
            txtBoveda.Name = "txtBoveda";
            txtBoveda.Size = new Size(150, 23);
            txtBoveda.TabIndex = 0;
            txtBoveda.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(99, 17);
            label2.Name = "label2";
            label2.Size = new Size(392, 29);
            label2.TabIndex = 9;
            label2.Text = "Ingresa tu mejor Linck";
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton6.BackColor = Color.Transparent;
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButton6.IconColor = Color.FromArgb(192, 0, 0);
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 25;
            iconButton6.Location = new Point(564, 3);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(26, 27);
            iconButton6.TabIndex = 11;
            iconButton6.UseVisualStyleBackColor = false;
            iconButton6.Click += iconButton6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-1, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 90);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton4.BackColor = Color.Transparent;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton4.IconColor = Color.FromArgb(192, 0, 0);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 25;
            iconButton4.Location = new Point(596, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(26, 27);
            iconButton4.TabIndex = 9;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(305, 112);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(317, 185);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 25);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(174, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(626, 394);
            panel2.TabIndex = 9;
            // 
            // Pantalla
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 480);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(Encabezado1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pantalla";
            Opacity = 0.98D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            TransparencyKey = Color.Transparent;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureImagenUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Encabezado1.ResumeLayout(false);
            Encabezado1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private Panel Encabezado1;
        private PictureBox pictureBox3;
        private Label label5;
        private PictureBox pictureBox5;
        private FontAwesome.Sharp.IconButton AgregarBT;
        private FontAwesome.Sharp.IconButton PersonalizarBT;
        private FontAwesome.Sharp.IconButton MenuBT;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton BTNCategoria;
        private Label label2;
        private Button btnEliminarCuenta;
        private PictureBox PictureImagenUser;
        private Button BTNMostrarUser;
        private Panel panel2;
        private ComboBox CBBoveda;
        private TextBox txtBoveda;
    }
}
