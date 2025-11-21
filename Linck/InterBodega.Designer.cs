namespace Linck
{
    partial class InterBodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterBodega));
            txtNombre = new TextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtNuevoNOmbre = new TextBox();
            label4 = new Label();
            btnGuardarCambios = new Button();
            BTGuardar = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            CBMisbovedas = new ComboBox();
            btNuevABOveda = new Button();
            btnMisBovedas = new Button();
            PanMisbovedas = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            PanAñadir = new Panel();
            label3 = new Label();
            PanEditar = new Panel();
            lbNombreboveda = new Label();
            label5 = new Label();
            PanOpciones = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            PanMisbovedas.SuspendLayout();
            PanAñadir.SuspendLayout();
            PanEditar.SuspendLayout();
            PanOpciones.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Location = new Point(36, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(137, 156, 48);
            label1.Location = new Point(111, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 2;
            label1.Text = "BOVEDAS";
            label1.Click += label1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = Color.Gold;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(9, 5);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 32);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // txtNuevoNOmbre
            // 
            txtNuevoNOmbre.BackColor = Color.White;
            txtNuevoNOmbre.Location = new Point(43, 135);
            txtNuevoNOmbre.Name = "txtNuevoNOmbre";
            txtNuevoNOmbre.Size = new Size(186, 23);
            txtNuevoNOmbre.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(137, 156, 48);
            label4.Location = new Point(76, 115);
            label4.Name = "label4";
            label4.Size = new Size(102, 17);
            label4.TabIndex = 13;
            label4.Text = "Nuevo Nombre";
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.Transparent;
            btnGuardarCambios.BackgroundImageLayout = ImageLayout.Center;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.ForeColor = Color.FromArgb(192, 192, 0);
            btnGuardarCambios.Location = new Point(93, 197);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(125, 23);
            btnGuardarCambios.TabIndex = 16;
            btnGuardarCambios.Text = "Guardar Cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // BTGuardar
            // 
            BTGuardar.BackColor = Color.Transparent;
            BTGuardar.BackgroundImageLayout = ImageLayout.Center;
            BTGuardar.FlatStyle = FlatStyle.Flat;
            BTGuardar.ForeColor = Color.FromArgb(192, 192, 0);
            BTGuardar.Location = new Point(84, 125);
            BTGuardar.Name = "BTGuardar";
            BTGuardar.Size = new Size(89, 33);
            BTGuardar.TabIndex = 6;
            BTGuardar.Text = "Guardar";
            BTGuardar.UseVisualStyleBackColor = false;
            BTGuardar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 41);
            panel1.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.Controls.Add(iconButton1);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(960, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(55, 41);
            panel6.TabIndex = 8;
            // 
            // CBMisbovedas
            // 
            CBMisbovedas.FormattingEnabled = true;
            CBMisbovedas.Location = new Point(8, 60);
            CBMisbovedas.Name = "CBMisbovedas";
            CBMisbovedas.Size = new Size(213, 23);
            CBMisbovedas.TabIndex = 7;
            CBMisbovedas.SelectedIndexChanged += CBMisbovedas_SelectedIndexChanged;
            // 
            // btNuevABOveda
            // 
            btNuevABOveda.BackColor = Color.Transparent;
            btNuevABOveda.BackgroundImageLayout = ImageLayout.Center;
            btNuevABOveda.FlatStyle = FlatStyle.Flat;
            btNuevABOveda.ForeColor = Color.FromArgb(192, 192, 0);
            btNuevABOveda.Location = new Point(70, 75);
            btNuevABOveda.Name = "btNuevABOveda";
            btNuevABOveda.Size = new Size(151, 33);
            btNuevABOveda.TabIndex = 8;
            btNuevABOveda.Text = "Añadir Boveda";
            btNuevABOveda.UseVisualStyleBackColor = false;
            btNuevABOveda.Click += btNuevABOveda_Click;
            // 
            // btnMisBovedas
            // 
            btnMisBovedas.BackColor = Color.Transparent;
            btnMisBovedas.BackgroundImageLayout = ImageLayout.Center;
            btnMisBovedas.FlatStyle = FlatStyle.Flat;
            btnMisBovedas.ForeColor = Color.FromArgb(192, 192, 0);
            btnMisBovedas.Location = new Point(70, 161);
            btnMisBovedas.Name = "btnMisBovedas";
            btnMisBovedas.Size = new Size(151, 33);
            btnMisBovedas.TabIndex = 9;
            btnMisBovedas.Text = "Mis Bovedas";
            btnMisBovedas.UseVisualStyleBackColor = false;
            btnMisBovedas.Click += btnMisBovedas_Click;
            // 
            // PanMisbovedas
            // 
            PanMisbovedas.BackColor = Color.Transparent;
            PanMisbovedas.Controls.Add(button3);
            PanMisbovedas.Controls.Add(button2);
            PanMisbovedas.Controls.Add(button1);
            PanMisbovedas.Controls.Add(label2);
            PanMisbovedas.Controls.Add(CBMisbovedas);
            PanMisbovedas.Dock = DockStyle.Left;
            PanMisbovedas.Location = new Point(0, 0);
            PanMisbovedas.Name = "PanMisbovedas";
            PanMisbovedas.Size = new Size(231, 300);
            PanMisbovedas.TabIndex = 18;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(192, 192, 0);
            button3.Location = new Point(73, 197);
            button3.Name = "button3";
            button3.Size = new Size(89, 23);
            button3.TabIndex = 11;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(192, 192, 0);
            button2.Location = new Point(132, 128);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 10;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(192, 192, 0);
            button1.Location = new Point(25, 128);
            button1.Name = "button1";
            button1.Size = new Size(79, 26);
            button1.TabIndex = 9;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(137, 156, 48);
            label2.Location = new Point(73, 19);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 8;
            label2.Text = "Mis bovedas";
            // 
            // PanAñadir
            // 
            PanAñadir.BackColor = Color.Transparent;
            PanAñadir.Controls.Add(label3);
            PanAñadir.Controls.Add(txtNombre);
            PanAñadir.Controls.Add(BTGuardar);
            PanAñadir.Dock = DockStyle.Left;
            PanAñadir.Location = new Point(519, 0);
            PanAñadir.Name = "PanAñadir";
            PanAñadir.Size = new Size(250, 300);
            PanAñadir.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(137, 156, 48);
            label3.Location = new Point(55, 49);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 3;
            label3.Text = "Añadir Boveda";
            // 
            // PanEditar
            // 
            PanEditar.BackColor = Color.Transparent;
            PanEditar.Controls.Add(lbNombreboveda);
            PanEditar.Controls.Add(label5);
            PanEditar.Controls.Add(txtNuevoNOmbre);
            PanEditar.Controls.Add(label4);
            PanEditar.Controls.Add(btnGuardarCambios);
            PanEditar.Dock = DockStyle.Left;
            PanEditar.Location = new Point(769, 0);
            PanEditar.Name = "PanEditar";
            PanEditar.Size = new Size(262, 300);
            PanEditar.TabIndex = 20;
            // 
            // lbNombreboveda
            // 
            lbNombreboveda.AutoSize = true;
            lbNombreboveda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreboveda.ForeColor = Color.FromArgb(137, 156, 48);
            lbNombreboveda.Location = new Point(43, 75);
            lbNombreboveda.Name = "lbNombreboveda";
            lbNombreboveda.Size = new Size(65, 25);
            lbNombreboveda.TabIndex = 17;
            lbNombreboveda.Text = "label6";
            lbNombreboveda.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(137, 156, 48);
            label5.Location = new Point(43, 10);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 4;
            label5.Text = "Editar Boveda";
            // 
            // PanOpciones
            // 
            PanOpciones.BackColor = Color.Transparent;
            PanOpciones.Controls.Add(btnMisBovedas);
            PanOpciones.Controls.Add(btNuevABOveda);
            PanOpciones.Controls.Add(label1);
            PanOpciones.Dock = DockStyle.Left;
            PanOpciones.Location = new Point(231, 0);
            PanOpciones.Name = "PanOpciones";
            PanOpciones.Size = new Size(288, 300);
            PanOpciones.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(PanEditar);
            panel5.Controls.Add(PanAñadir);
            panel5.Controls.Add(PanOpciones);
            panel5.Controls.Add(PanMisbovedas);
            panel5.Location = new Point(0, 41);
            panel5.Name = "panel5";
            panel5.Size = new Size(1015, 300);
            panel5.TabIndex = 22;
            // 
            // InterBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1015, 332);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterBodega";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += InterBodega_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            PanMisbovedas.ResumeLayout(false);
            PanMisbovedas.PerformLayout();
            PanAñadir.ResumeLayout(false);
            PanAñadir.PerformLayout();
            PanEditar.ResumeLayout(false);
            PanEditar.PerformLayout();
            PanOpciones.ResumeLayout(false);
            PanOpciones.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtNuevoNOmbre;
        private Label label4;
        private Button btnGuardarCambios;
        private Button BTGuardar;
        private Panel panel1;
        private Button btNuevABOveda;
        private ComboBox CBMisbovedas;
        private Button btnMisBovedas;
        private Panel PanMisbovedas;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Panel PanAñadir;
        private Label label3;
        private Panel PanEditar;
        private Label label5;
        private Label lbNombreboveda;
        private Panel PanOpciones;
        private Panel panel5;
        private Panel panel6;
    }
}