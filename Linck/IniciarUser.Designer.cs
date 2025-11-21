namespace Linck
{
    partial class IniciarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarUser));
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            TXTUser = new TextBox();
            txtPasword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LBAgregarCorre = new LinkLabel();
            MostrarPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MostrarPassword).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.ActiveCaptionText;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.ForeColor = SystemColors.ButtonFace;
            btnIniciar.Location = new Point(271, 194);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(174, 32);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TXTUser
            // 
            TXTUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            TXTUser.ForeColor = Color.Silver;
            TXTUser.Location = new Point(257, 56);
            TXTUser.Name = "TXTUser";
            TXTUser.Size = new Size(207, 33);
            TXTUser.TabIndex = 6;
            TXTUser.Text = "Usuario";
            TXTUser.TextAlign = HorizontalAlignment.Center;
            TXTUser.TextChanged += TXTUser_TextChanged;
            TXTUser.Enter += TXTUser_Enter;
            TXTUser.Leave += TXTUser_Leave;
            // 
            // txtPasword
            // 
            txtPasword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtPasword.ForeColor = Color.Silver;
            txtPasword.Location = new Point(257, 139);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.Size = new Size(207, 33);
            txtPasword.TabIndex = 7;
            txtPasword.Text = "Contraseña";
            txtPasword.TextAlign = HorizontalAlignment.Center;
            txtPasword.Enter += txtPasword_Enter;
            txtPasword.Leave += txtPasword_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(271, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(257, 121);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "PASSWORD";
            // 
            // LBAgregarCorre
            // 
            LBAgregarCorre.AutoSize = true;
            LBAgregarCorre.Cursor = Cursors.Hand;
            LBAgregarCorre.Location = new Point(386, 245);
            LBAgregarCorre.Name = "LBAgregarCorre";
            LBAgregarCorre.Size = new Size(88, 15);
            LBAgregarCorre.TabIndex = 10;
            LBAgregarCorre.TabStop = true;
            LBAgregarCorre.Text = "Agregar Correo";
            LBAgregarCorre.LinkClicked += LBAgregarCorre_LinkClicked;
            // 
            // MostrarPassword
            // 
            MostrarPassword.Image = Properties.Resources._2OcultarContra;
            MostrarPassword.Location = new Point(472, 142);
            MostrarPassword.Name = "MostrarPassword";
            MostrarPassword.Size = new Size(27, 27);
            MostrarPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            MostrarPassword.TabIndex = 11;
            MostrarPassword.TabStop = false;
            MostrarPassword.Click += MostrarPassword_Click;
            MostrarPassword.MouseEnter += MostrarPassword_MouseEnter;
            // 
            // IniciarUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(529, 279);
            Controls.Add(MostrarPassword);
            Controls.Add(LBAgregarCorre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPasword);
            Controls.Add(TXTUser);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IniciarUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IniciarUser";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MostrarPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIniciar;
        private PictureBox pictureBox1;
        private TextBox TXTUser;
        private TextBox txtPasword;
        private Label label1;
        private Label label2;
        private LinkLabel LBAgregarCorre;
        private PictureBox MostrarPassword;
    }
}