namespace Linck
{
    partial class EditLick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLick));
            pic_Imagen = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtURL = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BTConfirmar = new Button();
            IConoRegresar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pic_Imagen).BeginInit();
            SuspendLayout();
            // 
            // pic_Imagen
            // 
            pic_Imagen.Image = (Image)resources.GetObject("pic_Imagen.Image");
            pic_Imagen.Location = new Point(84, 60);
            pic_Imagen.Name = "pic_Imagen";
            pic_Imagen.Size = new Size(100, 79);
            pic_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Imagen.TabIndex = 0;
            pic_Imagen.TabStop = false;
            pic_Imagen.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(97, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Editar Foto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(95, 1);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 2;
            label1.Text = "Editar Linck";
            label1.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 208);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(53, 268);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(173, 23);
            txtURL.TabIndex = 5;
            txtURL.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(24, 190);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(53, 250);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Linck";
            // 
            // BTConfirmar
            // 
            BTConfirmar.BackColor = Color.Transparent;
            BTConfirmar.FlatStyle = FlatStyle.Flat;
            BTConfirmar.ForeColor = Color.FromArgb(128, 255, 128);
            BTConfirmar.Location = new Point(129, 313);
            BTConfirmar.Name = "BTConfirmar";
            BTConfirmar.Size = new Size(75, 23);
            BTConfirmar.TabIndex = 9;
            BTConfirmar.Text = "Confirmar";
            BTConfirmar.UseVisualStyleBackColor = false;
            BTConfirmar.Click += BTConfirmar_Click;
            // 
            // IConoRegresar
            // 
            IConoRegresar.BackColor = Color.Transparent;
            IConoRegresar.Cursor = Cursors.Hand;
            IConoRegresar.FlatStyle = FlatStyle.Flat;
            IConoRegresar.IconChar = FontAwesome.Sharp.IconChar.SquareCaretLeft;
            IConoRegresar.IconColor = Color.Gold;
            IConoRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IConoRegresar.IconSize = 25;
            IConoRegresar.Location = new Point(1, -2);
            IConoRegresar.Name = "IConoRegresar";
            IConoRegresar.Size = new Size(33, 35);
            IConoRegresar.TabIndex = 10;
            IConoRegresar.UseVisualStyleBackColor = false;
            IConoRegresar.Click += iconButton1_Click;
            // 
            // EditLick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(255, 357);
            Controls.Add(IConoRegresar);
            Controls.Add(BTConfirmar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtURL);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pic_Imagen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditLick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditLick";
            TopMost = true;
            Load += EditLick_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Imagen;
        private Button button1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtURL;
        private Label label2;
        private Label label3;
        private Button BTConfirmar;
        private FontAwesome.Sharp.IconButton IConoRegresar;
    }
}