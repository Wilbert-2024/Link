namespace Linck
{
    partial class Visualizacion_lick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizacion_lick));
            panel1 = new Panel();
            BTEliminar = new Button();
            BTEditar = new Button();
            BTActualizar = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Fypanel_lista_LINK = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(BTEliminar);
            panel1.Controls.Add(BTEditar);
            panel1.Controls.Add(BTActualizar);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 65);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BTEliminar
            // 
            BTEliminar.BackColor = Color.Transparent;
            BTEliminar.FlatStyle = FlatStyle.Flat;
            BTEliminar.ForeColor = Color.FromArgb(192, 192, 0);
            BTEliminar.Location = new Point(120, 34);
            BTEliminar.Name = "BTEliminar";
            BTEliminar.RightToLeft = RightToLeft.Yes;
            BTEliminar.Size = new Size(75, 23);
            BTEliminar.TabIndex = 3;
            BTEliminar.Text = "Eliminar";
            BTEliminar.UseVisualStyleBackColor = false;
            BTEliminar.Click += BTEliminar_Click;
            // 
            // BTEditar
            // 
            BTEditar.BackColor = Color.Transparent;
            BTEditar.FlatStyle = FlatStyle.Flat;
            BTEditar.ForeColor = Color.FromArgb(192, 192, 0);
            BTEditar.Location = new Point(222, 35);
            BTEditar.Name = "BTEditar";
            BTEditar.Size = new Size(75, 23);
            BTEditar.TabIndex = 2;
            BTEditar.Text = "Editar";
            BTEditar.UseVisualStyleBackColor = false;
            BTEditar.Click += BTEditar_Click;
            // 
            // BTActualizar
            // 
            BTActualizar.BackColor = Color.Transparent;
            BTActualizar.FlatStyle = FlatStyle.Flat;
            BTActualizar.ForeColor = Color.FromArgb(192, 192, 0);
            BTActualizar.Location = new Point(320, 34);
            BTActualizar.Name = "BTActualizar";
            BTActualizar.Size = new Size(75, 23);
            BTActualizar.TabIndex = 1;
            BTActualizar.Text = "Actualizar";
            BTActualizar.UseVisualStyleBackColor = false;
            BTActualizar.Click += BTActualizar_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.DarkGoldenrod;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareCaretLeft;
            iconButton1.IconColor = Color.Goldenrod;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(29, 29);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(30, 28);
            iconButton1.TabIndex = 0;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // Fypanel_lista_LINK
            // 
            Fypanel_lista_LINK.BackgroundImage = (Image)resources.GetObject("Fypanel_lista_LINK.BackgroundImage");
            Fypanel_lista_LINK.Dock = DockStyle.Fill;
            Fypanel_lista_LINK.Location = new Point(0, 65);
            Fypanel_lista_LINK.Name = "Fypanel_lista_LINK";
            Fypanel_lista_LINK.Size = new Size(626, 329);
            Fypanel_lista_LINK.TabIndex = 1;
            Fypanel_lista_LINK.Paint += flowLayoutPanel1_Paint;
            // 
            // Visualizacion_lick
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 394);
            Controls.Add(Fypanel_lista_LINK);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Visualizacion_lick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizacion_lick";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel Fypanel_lista_LINK;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button BTEliminar;
        private Button BTEditar;
        private Button BTActualizar;
    }
}