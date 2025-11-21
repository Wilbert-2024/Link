namespace Linck
{
    partial class AgregarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUser));
            txtGmail = new TextBox();
            txtContra = new TextBox();
            txtConfirmarContra = new TextBox();
            btnAgregar = new Button();
            pictureBox1 = new PictureBox();
            txtNombre = new TextBox();
            Pictu_user = new PictureBox();
            btnAgrgarFoto = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pictu_user).BeginInit();
            SuspendLayout();
            // 
            // txtGmail
            // 
            txtGmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtGmail.ForeColor = Color.Silver;
            txtGmail.Location = new Point(30, 202);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(186, 25);
            txtGmail.TabIndex = 0;
            txtGmail.Text = "Gmail";
            txtGmail.TextAlign = HorizontalAlignment.Center;
            txtGmail.TextChanged += txtGmail_TextChanged;
            txtGmail.Enter += txtGmail_Enter;
            txtGmail.Leave += txtGmail_Leave;
            // 
            // txtContra
            // 
            txtContra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtContra.ForeColor = Color.Silver;
            txtContra.Location = new Point(30, 242);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(186, 25);
            txtContra.TabIndex = 1;
            txtContra.Text = "Contraseña";
            txtContra.TextAlign = HorizontalAlignment.Center;
            txtContra.Enter += txtContra_Enter;
            txtContra.Leave += txtContra_Leave;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtConfirmarContra.ForeColor = Color.Silver;
            txtConfirmarContra.Location = new Point(30, 285);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(186, 25);
            txtConfirmarContra.TabIndex = 2;
            txtConfirmarContra.Text = "Confirmar contraseña";
            txtConfirmarContra.TextAlign = HorizontalAlignment.Center;
            txtConfirmarContra.Enter += txtConfirmarContra_Enter;
            txtConfirmarContra.Leave += txtConfirmarContra_Leave;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(64, 326);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 28);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtNombre.ForeColor = Color.Silver;
            txtNombre.Location = new Point(30, 154);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 25);
            txtNombre.TabIndex = 5;
            txtNombre.Text = "Nombre";
            txtNombre.TextAlign = HorizontalAlignment.Center;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Enter += txtNombre_Enter;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // Pictu_user
            // 
            Pictu_user.Image = Properties.Resources.forr;
            Pictu_user.Location = new Point(150, 25);
            Pictu_user.Name = "Pictu_user";
            Pictu_user.Size = new Size(101, 94);
            Pictu_user.SizeMode = PictureBoxSizeMode.StretchImage;
            Pictu_user.TabIndex = 6;
            Pictu_user.TabStop = false;
            Pictu_user.Click += Pictu_user_Click;
            // 
            // btnAgrgarFoto
            // 
            btnAgrgarFoto.Cursor = Cursors.Hand;
            btnAgrgarFoto.Location = new Point(149, 125);
            btnAgrgarFoto.Name = "btnAgrgarFoto";
            btnAgrgarFoto.Size = new Size(102, 23);
            btnAgrgarFoto.TabIndex = 7;
            btnAgrgarFoto.Text = "AgregarFoto";
            btnAgrgarFoto.UseVisualStyleBackColor = true;
            btnAgrgarFoto.Click += btnAgrgarFoto_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton1.IconColor = Color.FromArgb(192, 0, 0);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(235, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(29, 32);
            iconButton1.TabIndex = 8;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // AgregarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(266, 387);
            Controls.Add(iconButton1);
            Controls.Add(btnAgrgarFoto);
            Controls.Add(Pictu_user);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnAgregar);
            Controls.Add(txtConfirmarContra);
            Controls.Add(txtContra);
            Controls.Add(txtGmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarUser";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pictu_user).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGmail;
        private TextBox txtContra;
        private TextBox txtConfirmarContra;
        private Button btnAgregar;
        private PictureBox pictureBox1;
        private TextBox txtNombre;
        private PictureBox Pictu_user;
        private Button btnAgrgarFoto;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}