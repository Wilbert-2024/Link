namespace Linck
{
    partial class NuevaCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCat));
            BTNAgregar = new Button();
            txtNuevCategoria = new TextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictCategoria = new PictureBox();
            BTN_Foto = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictCategoria).BeginInit();
            SuspendLayout();
            // 
            // BTNAgregar
            // 
            BTNAgregar.BackColor = Color.Transparent;
            BTNAgregar.FlatStyle = FlatStyle.Flat;
            BTNAgregar.ForeColor = Color.Transparent;
            BTNAgregar.Location = new Point(255, 110);
            BTNAgregar.Name = "BTNAgregar";
            BTNAgregar.Size = new Size(83, 27);
            BTNAgregar.TabIndex = 0;
            BTNAgregar.Text = "Agregar";
            BTNAgregar.UseVisualStyleBackColor = false;
            BTNAgregar.Click += Agregar_Click;
            // 
            // txtNuevCategoria
            // 
            txtNuevCategoria.BackColor = SystemColors.InfoText;
            txtNuevCategoria.ForeColor = Color.FromArgb(192, 192, 0);
            txtNuevCategoria.Location = new Point(212, 56);
            txtNuevCategoria.Multiline = true;
            txtNuevCategoria.Name = "txtNuevCategoria";
            txtNuevCategoria.Size = new Size(170, 33);
            txtNuevCategoria.TabIndex = 13;
            txtNuevCategoria.TextChanged += txtNuevCategoria_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(141, 12);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 14;
            label1.Text = "Nueva categoria";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.FromArgb(192, 192, 0);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(12, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 33);
            iconButton1.TabIndex = 15;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // pictCategoria
            // 
            pictCategoria.BackColor = Color.Transparent;
            pictCategoria.Location = new Point(86, 36);
            pictCategoria.Name = "pictCategoria";
            pictCategoria.Size = new Size(104, 83);
            pictCategoria.SizeMode = PictureBoxSizeMode.StretchImage;
            pictCategoria.TabIndex = 16;
            pictCategoria.TabStop = false;
            // 
            // BTN_Foto
            // 
            BTN_Foto.BackColor = Color.Transparent;
            BTN_Foto.FlatStyle = FlatStyle.Flat;
            BTN_Foto.ForeColor = Color.Transparent;
            BTN_Foto.Location = new Point(77, 125);
            BTN_Foto.Name = "BTN_Foto";
            BTN_Foto.Size = new Size(116, 27);
            BTN_Foto.TabIndex = 17;
            BTN_Foto.Text = "Agregar Imagen";
            BTN_Foto.UseVisualStyleBackColor = false;
            BTN_Foto.Click += BTN_Foto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(244, 41);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 18;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // NuevaCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 16, 78);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(415, 197);
            Controls.Add(label2);
            Controls.Add(BTN_Foto);
            Controls.Add(pictCategoria);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(txtNuevCategoria);
            Controls.Add(BTNAgregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevaCat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaCat";
            TopMost = true;
            Load += NuevaCat_Load;
            ((System.ComponentModel.ISupportInitialize)pictCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNAgregar;
        private TextBox txtNuevCategoria;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictCategoria;
        private Button BTN_Foto;
        private Label label2;
    }
}