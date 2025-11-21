namespace Linck
{
    partial class EditCate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCate));
            label2 = new Label();
            txtNuevCategoria = new TextBox();
            BTEditar = new Button();
            BTEliminar = new Button();
            pictCategoria = new PictureBox();
            PAN_Agregar = new Panel();
            btnImage = new Button();
            CBCategoria = new ComboBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblEditarEliminar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictCategoria).BeginInit();
            PAN_Agregar.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(222, 58);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 23;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // txtNuevCategoria
            // 
            txtNuevCategoria.BackColor = SystemColors.InfoText;
            txtNuevCategoria.Font = new Font("Segoe UI", 12F);
            txtNuevCategoria.ForeColor = Color.FromArgb(192, 192, 0);
            txtNuevCategoria.Location = new Point(161, 85);
            txtNuevCategoria.Multiline = true;
            txtNuevCategoria.Name = "txtNuevCategoria";
            txtNuevCategoria.Size = new Size(179, 33);
            txtNuevCategoria.TabIndex = 20;
            txtNuevCategoria.TextAlign = HorizontalAlignment.Center;
            txtNuevCategoria.TextChanged += txtNuevCategoria_TextChanged;
            // 
            // BTEditar
            // 
            BTEditar.BackColor = Color.Transparent;
            BTEditar.FlatStyle = FlatStyle.Flat;
            BTEditar.ForeColor = Color.Transparent;
            BTEditar.Location = new Point(247, 138);
            BTEditar.Name = "BTEditar";
            BTEditar.Size = new Size(94, 27);
            BTEditar.TabIndex = 19;
            BTEditar.Text = "Guarda ";
            BTEditar.UseVisualStyleBackColor = false;
            BTEditar.Click += BTEditar_Click;
            // 
            // BTEliminar
            // 
            BTEliminar.BackColor = Color.Transparent;
            BTEliminar.FlatStyle = FlatStyle.Flat;
            BTEliminar.ForeColor = Color.Transparent;
            BTEliminar.Location = new Point(160, 139);
            BTEliminar.Name = "BTEliminar";
            BTEliminar.Size = new Size(71, 27);
            BTEliminar.TabIndex = 25;
            BTEliminar.Text = "Eliminar";
            BTEliminar.UseVisualStyleBackColor = false;
            BTEliminar.Click += BTEliminar_Click;
            // 
            // pictCategoria
            // 
            pictCategoria.BackColor = Color.Transparent;
            pictCategoria.Location = new Point(23, 53);
            pictCategoria.Name = "pictCategoria";
            pictCategoria.Size = new Size(109, 85);
            pictCategoria.SizeMode = PictureBoxSizeMode.StretchImage;
            pictCategoria.TabIndex = 26;
            pictCategoria.TabStop = false;
            pictCategoria.Click += pictCategoria_Click;
            // 
            // PAN_Agregar
            // 
            PAN_Agregar.BackColor = Color.Coral;
            PAN_Agregar.BackgroundImage = (Image)resources.GetObject("PAN_Agregar.BackgroundImage");
            PAN_Agregar.Controls.Add(btnImage);
            PAN_Agregar.Controls.Add(CBCategoria);
            PAN_Agregar.Controls.Add(iconButton1);
            PAN_Agregar.Controls.Add(BTEliminar);
            PAN_Agregar.Controls.Add(pictCategoria);
            PAN_Agregar.Controls.Add(BTEditar);
            PAN_Agregar.Controls.Add(label2);
            PAN_Agregar.Controls.Add(lblEditarEliminar);
            PAN_Agregar.Controls.Add(txtNuevCategoria);
            PAN_Agregar.Dock = DockStyle.Left;
            PAN_Agregar.Location = new Point(0, 0);
            PAN_Agregar.Name = "PAN_Agregar";
            PAN_Agregar.Size = new Size(526, 204);
            PAN_Agregar.TabIndex = 27;
            PAN_Agregar.Paint += panel1_Paint;
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.Transparent;
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.ForeColor = Color.Transparent;
            btnImage.Location = new Point(33, 147);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(94, 27);
            btnImage.TabIndex = 29;
            btnImage.Text = "Insert Image";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // CBCategoria
            // 
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(364, 27);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(150, 23);
            CBCategoria.TabIndex = 28;
            CBCategoria.SelectedIndexChanged += CBCategoria_SelectedIndexChanged;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareCaretLeft;
            iconButton1.IconColor = Color.FromArgb(192, 192, 0);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(23, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(29, 35);
            iconButton1.TabIndex = 27;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // lblEditarEliminar
            // 
            lblEditarEliminar.AutoSize = true;
            lblEditarEliminar.BackColor = Color.Transparent;
            lblEditarEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditarEliminar.ForeColor = Color.FromArgb(192, 192, 0);
            lblEditarEliminar.Location = new Point(118, 20);
            lblEditarEliminar.Name = "lblEditarEliminar";
            lblEditarEliminar.Size = new Size(215, 21);
            lblEditarEliminar.TabIndex = 27;
            lblEditarEliminar.Text = "Editar o Eliminar Categoria";
            lblEditarEliminar.TextAlign = ContentAlignment.TopCenter;
            lblEditarEliminar.Click += label3_Click;
            // 
            // EditCate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(526, 204);
            Controls.Add(PAN_Agregar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditCate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCate";
            TopMost = true;
            Load += EditCate_Load;
            ((System.ComponentModel.ISupportInitialize)pictCategoria).EndInit();
            PAN_Agregar.ResumeLayout(false);
            PAN_Agregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Button BTN_Foto;
        private TextBox txtNuevCategoria;
        private Button BTEditar;
        private Button BTEliminar;
        private PictureBox pictCategoria;
        private Panel PAN_Agregar;
        private Label lblEditarEliminar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ComboBox CBCategoria;
        private Button btnImage;
    }
}