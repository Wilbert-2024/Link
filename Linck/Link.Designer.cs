namespace Linck
{
    partial class Link
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Link));
            txt_ingrese_link = new TextBox();
            txt_nombre_link = new TextBox();
            label1 = new Label();
            pictImagen = new FontAwesome.Sharp.IconPictureBox();
            btnImagen = new Button();
            btn_Agregar_Link = new Button();
            Exit = new FontAwesome.Sharp.IconButton();
            CBCategoria = new ComboBox();
            CBBoveda = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictImagen).BeginInit();
            SuspendLayout();
            // 
            // txt_ingrese_link
            // 
            txt_ingrese_link.BackColor = Color.LightGray;
            txt_ingrese_link.BorderStyle = BorderStyle.FixedSingle;
            txt_ingrese_link.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ingrese_link.ForeColor = Color.DimGray;
            txt_ingrese_link.Location = new Point(35, 193);
            txt_ingrese_link.Multiline = true;
            txt_ingrese_link.Name = "txt_ingrese_link";
            txt_ingrese_link.Size = new Size(227, 26);
            txt_ingrese_link.TabIndex = 1;
            txt_ingrese_link.Tag = "";
            txt_ingrese_link.Text = "Ingresar link";
            txt_ingrese_link.TextAlign = HorizontalAlignment.Center;
            txt_ingrese_link.Enter += txt_ingrese_link_Enter;
            txt_ingrese_link.Leave += txt_ingrese_link_Leave;
            // 
            // txt_nombre_link
            // 
            txt_nombre_link.BackColor = Color.LightGray;
            txt_nombre_link.BorderStyle = BorderStyle.FixedSingle;
            txt_nombre_link.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txt_nombre_link.ForeColor = Color.DimGray;
            txt_nombre_link.Location = new Point(35, 243);
            txt_nombre_link.Multiline = true;
            txt_nombre_link.Name = "txt_nombre_link";
            txt_nombre_link.Size = new Size(227, 26);
            txt_nombre_link.TabIndex = 2;
            txt_nombre_link.Tag = "";
            txt_nombre_link.Text = "Nombre";
            txt_nombre_link.TextAlign = HorizontalAlignment.Center;
            txt_nombre_link.Enter += txt_nombre_link_Enter;
            txt_nombre_link.Leave += txt_nombre_link_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 3;
            label1.Text = "New link";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictImagen
            // 
            pictImagen.BackColor = Color.Transparent;
            pictImagen.ForeColor = Color.Lime;
            pictImagen.IconChar = FontAwesome.Sharp.IconChar.Save;
            pictImagen.IconColor = Color.Lime;
            pictImagen.IconFont = FontAwesome.Sharp.IconFont.Regular;
            pictImagen.IconSize = 93;
            pictImagen.Location = new Point(102, 42);
            pictImagen.Name = "pictImagen";
            pictImagen.Size = new Size(101, 93);
            pictImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictImagen.TabIndex = 7;
            pictImagen.TabStop = false;
            // 
            // btnImagen
            // 
            btnImagen.BackColor = Color.Transparent;
            btnImagen.BackgroundImageLayout = ImageLayout.Zoom;
            btnImagen.FlatStyle = FlatStyle.Flat;
            btnImagen.ForeColor = Color.Lime;
            btnImagen.Location = new Point(74, 141);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(168, 31);
            btnImagen.TabIndex = 8;
            btnImagen.Text = "Agregar Imajen";
            btnImagen.UseVisualStyleBackColor = false;
            btnImagen.Click += btnImagen_Click;
            // 
            // btn_Agregar_Link
            // 
            btn_Agregar_Link.BackColor = Color.Transparent;
            btn_Agregar_Link.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Agregar_Link.FlatStyle = FlatStyle.Flat;
            btn_Agregar_Link.ForeColor = Color.Blue;
            btn_Agregar_Link.Location = new Point(74, 349);
            btn_Agregar_Link.Name = "btn_Agregar_Link";
            btn_Agregar_Link.Size = new Size(168, 34);
            btn_Agregar_Link.TabIndex = 9;
            btn_Agregar_Link.Text = "Agregar";
            btn_Agregar_Link.UseVisualStyleBackColor = false;
            btn_Agregar_Link.Click += btn_Agregar_Link_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.Transparent;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            Exit.IconColor = Color.FromArgb(192, 0, 0);
            Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Exit.IconSize = 25;
            Exit.Location = new Point(281, -1);
            Exit.Name = "Exit";
            Exit.Size = new Size(26, 27);
            Exit.TabIndex = 10;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // CBCategoria
            // 
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.Font = new Font("Segoe UI", 11F);
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(163, 299);
            CBCategoria.MaxDropDownItems = 5;
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(123, 28);
            CBCategoria.TabIndex = 14;
            // 
            // CBBoveda
            // 
            CBBoveda.DropDownStyle = ComboBoxStyle.DropDownList;
            CBBoveda.Font = new Font("Segoe UI", 11F);
            CBBoveda.FormattingEnabled = true;
            CBBoveda.Location = new Point(12, 300);
            CBBoveda.MaxDropDownItems = 5;
            CBBoveda.Name = "CBBoveda";
            CBBoveda.Size = new Size(134, 28);
            CBBoveda.TabIndex = 15;
            CBBoveda.SelectedIndexChanged += CBBoveda_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(44, 290);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 16;
            label2.Text = "Boveda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(193, 289);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 17;
            label3.Text = "Categoria";
            // 
            // Link
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(305, 413);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CBBoveda);
            Controls.Add(CBCategoria);
            Controls.Add(Exit);
            Controls.Add(btn_Agregar_Link);
            Controls.Add(btnImagen);
            Controls.Add(pictImagen);
            Controls.Add(label1);
            Controls.Add(txt_nombre_link);
            Controls.Add(txt_ingrese_link);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Link";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Link";
            TopMost = true;
            Load += Link_Load;
            ((System.ComponentModel.ISupportInitialize)pictImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_ingrese_link;
        private TextBox txt_nombre_link;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox pictImagen;
        private Button btnImagen;
        private Button btn_Agregar_Link;
        private FontAwesome.Sharp.IconButton Exit;
        private ComboBox CBCategoria;
        private ComboBox CBBoveda;
        private Label label2;
        private Label label3;
    }
}