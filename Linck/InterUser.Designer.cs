namespace Linck
{
    partial class InterUser
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
            RegresarBT = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            BTEditar = new Button();
            BTEliminar = new FontAwesome.Sharp.IconButton();
            AgregarUserBT = new FontAwesome.Sharp.IconButton();
            BTActualizar = new FontAwesome.Sharp.IconButton();
            PanelEditor = new Panel();
            BTCanselar = new Button();
            BTGuardar = new Button();
            BTagregarFoto = new Button();
            PicImagen = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtContras = new TextBox();
            TxtGmail = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            Fypanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            PanelEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImagen).BeginInit();
            SuspendLayout();
            // 
            // RegresarBT
            // 
            RegresarBT.BackColor = Color.FromArgb(0, 64, 64);
            RegresarBT.FlatStyle = FlatStyle.Popup;
            RegresarBT.ForeColor = SystemColors.ButtonHighlight;
            RegresarBT.IconChar = FontAwesome.Sharp.IconChar.None;
            RegresarBT.IconColor = Color.Black;
            RegresarBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RegresarBT.Location = new Point(3, 14);
            RegresarBT.Name = "RegresarBT";
            RegresarBT.Size = new Size(75, 23);
            RegresarBT.TabIndex = 1;
            RegresarBT.Text = "Regresar";
            RegresarBT.UseVisualStyleBackColor = false;
            RegresarBT.Click += RegresarBT_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(RegresarBT);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(PanelEditor);
            panel2.Controls.Add(Fypanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 410);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(BTEditar);
            panel3.Controls.Add(BTEliminar);
            panel3.Controls.Add(AgregarUserBT);
            panel3.Controls.Add(BTActualizar);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(616, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 410);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint_1;
            // 
            // BTEditar
            // 
            BTEditar.FlatStyle = FlatStyle.Flat;
            BTEditar.ForeColor = SystemColors.ButtonFace;
            BTEditar.Location = new Point(58, 142);
            BTEditar.Name = "BTEditar";
            BTEditar.Size = new Size(75, 23);
            BTEditar.TabIndex = 5;
            BTEditar.Text = "Editar";
            BTEditar.UseVisualStyleBackColor = true;
            BTEditar.Click += BTEditar_Click_1;
            // 
            // BTEliminar
            // 
            BTEliminar.BackColor = Color.FromArgb(0, 64, 64);
            BTEliminar.FlatStyle = FlatStyle.Popup;
            BTEliminar.ForeColor = SystemColors.ButtonHighlight;
            BTEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTEliminar.IconColor = Color.Black;
            BTEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTEliminar.Location = new Point(58, 192);
            BTEliminar.Name = "BTEliminar";
            BTEliminar.Size = new Size(75, 23);
            BTEliminar.TabIndex = 2;
            BTEliminar.Text = "Eliminar";
            BTEliminar.UseVisualStyleBackColor = false;
            BTEliminar.Click += BTEliminar_Click;
            // 
            // AgregarUserBT
            // 
            AgregarUserBT.BackColor = Color.FromArgb(0, 64, 64);
            AgregarUserBT.FlatStyle = FlatStyle.Popup;
            AgregarUserBT.ForeColor = SystemColors.ButtonHighlight;
            AgregarUserBT.IconChar = FontAwesome.Sharp.IconChar.None;
            AgregarUserBT.IconColor = Color.Black;
            AgregarUserBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AgregarUserBT.Location = new Point(34, 32);
            AgregarUserBT.Name = "AgregarUserBT";
            AgregarUserBT.Size = new Size(119, 23);
            AgregarUserBT.TabIndex = 4;
            AgregarUserBT.Text = "Agregar Usuario";
            AgregarUserBT.UseVisualStyleBackColor = false;
            AgregarUserBT.Click += AgregarUserBT_Click_1;
            // 
            // BTActualizar
            // 
            BTActualizar.BackColor = Color.FromArgb(0, 64, 64);
            BTActualizar.FlatStyle = FlatStyle.Popup;
            BTActualizar.ForeColor = SystemColors.ButtonHighlight;
            BTActualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTActualizar.IconColor = Color.Black;
            BTActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTActualizar.Location = new Point(58, 84);
            BTActualizar.Name = "BTActualizar";
            BTActualizar.Size = new Size(75, 23);
            BTActualizar.TabIndex = 3;
            BTActualizar.Text = "Actualizar";
            BTActualizar.UseVisualStyleBackColor = false;
            BTActualizar.Click += BTActualizar_Click;
            // 
            // PanelEditor
            // 
            PanelEditor.Controls.Add(BTCanselar);
            PanelEditor.Controls.Add(BTGuardar);
            PanelEditor.Controls.Add(BTagregarFoto);
            PanelEditor.Controls.Add(PicImagen);
            PanelEditor.Controls.Add(label4);
            PanelEditor.Controls.Add(label3);
            PanelEditor.Controls.Add(label2);
            PanelEditor.Controls.Add(txtContras);
            PanelEditor.Controls.Add(TxtGmail);
            PanelEditor.Controls.Add(txtNombre);
            PanelEditor.Controls.Add(label1);
            PanelEditor.Dock = DockStyle.Left;
            PanelEditor.Location = new Point(338, 0);
            PanelEditor.Name = "PanelEditor";
            PanelEditor.Size = new Size(278, 410);
            PanelEditor.TabIndex = 12;
            // 
            // BTCanselar
            // 
            BTCanselar.Location = new Point(59, 377);
            BTCanselar.Name = "BTCanselar";
            BTCanselar.Size = new Size(75, 23);
            BTCanselar.TabIndex = 10;
            BTCanselar.Text = "Cancelar";
            BTCanselar.UseVisualStyleBackColor = true;
            // 
            // BTGuardar
            // 
            BTGuardar.Location = new Point(164, 377);
            BTGuardar.Name = "BTGuardar";
            BTGuardar.Size = new Size(75, 23);
            BTGuardar.TabIndex = 9;
            BTGuardar.Text = "Guardar";
            BTGuardar.UseVisualStyleBackColor = true;
            BTGuardar.Click += BTGuardar_Click;
            // 
            // BTagregarFoto
            // 
            BTagregarFoto.FlatStyle = FlatStyle.Flat;
            BTagregarFoto.ForeColor = SystemColors.ButtonFace;
            BTagregarFoto.Location = new Point(134, 107);
            BTagregarFoto.Name = "BTagregarFoto";
            BTagregarFoto.Size = new Size(105, 29);
            BTagregarFoto.TabIndex = 8;
            BTagregarFoto.Text = "Cambiar Foto";
            BTagregarFoto.UseVisualStyleBackColor = true;
            BTagregarFoto.Click += BTagregarFoto_Click_1;
            // 
            // PicImagen
            // 
            PicImagen.Location = new Point(28, 70);
            PicImagen.Name = "PicImagen";
            PicImagen.Size = new Size(100, 78);
            PicImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImagen.TabIndex = 7;
            PicImagen.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(69, 297);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 6;
            label4.Text = "Nueva Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(76, 229);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 5;
            label3.Text = "Gmail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(75, 162);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtContras
            // 
            txtContras.Location = new Point(71, 321);
            txtContras.Name = "txtContras";
            txtContras.PasswordChar = '*';
            txtContras.Size = new Size(136, 23);
            txtContras.TabIndex = 3;
            // 
            // TxtGmail
            // 
            TxtGmail.Location = new Point(71, 250);
            TxtGmail.Name = "TxtGmail";
            TxtGmail.Size = new Size(136, 23);
            TxtGmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 183);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(136, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(86, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Editar Correo";
            // 
            // Fypanel
            // 
            Fypanel.Dock = DockStyle.Left;
            Fypanel.Location = new Point(0, 0);
            Fypanel.Name = "Fypanel";
            Fypanel.Size = new Size(338, 410);
            Fypanel.TabIndex = 10;
            // 
            // InterUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InterUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InterUser";
            Load += InterUser_Load_1;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            PanelEditor.ResumeLayout(false);
            PanelEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton RegresarBT;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button BTEditar;
        private FontAwesome.Sharp.IconButton BTEliminar;
        private FontAwesome.Sharp.IconButton AgregarUserBT;
        private FontAwesome.Sharp.IconButton BTActualizar;
        private Panel PanelEditor;
        private Button BTCanselar;
        private Button BTGuardar;
        private Button BTagregarFoto;
        private PictureBox PicImagen;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtContras;
        private TextBox TxtGmail;
        private TextBox txtNombre;
        private Label label1;
        private FlowLayoutPanel Fypanel;
    }
}