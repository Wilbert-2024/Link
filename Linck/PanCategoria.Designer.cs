namespace Linck
{
    partial class PanCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanCategoria));
            panel1 = new Panel();
            button1 = new Button();
            RegresarBT = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            deprotes = new FontAwesome.Sharp.IconButton();
            tecnologia = new FontAwesome.Sharp.IconButton();
            faceboock = new FontAwesome.Sharp.IconButton();
            IconAgregar_Categoria = new FontAwesome.Sharp.IconButton();
            ico1 = new FontAwesome.Sharp.IconButton();
            ico2 = new FontAwesome.Sharp.IconButton();
            icon3 = new FontAwesome.Sharp.IconButton();
            btnRefrescar = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            proyecto = new FontAwesome.Sharp.IconButton();
            Favorito = new FontAwesome.Sharp.IconButton();
            documentacion = new FontAwesome.Sharp.IconButton();
            Noticias = new FontAwesome.Sharp.IconButton();
            tutorial = new FontAwesome.Sharp.IconButton();
            PanelPredeterminado = new Panel();
            panel3 = new Panel();
            pane4 = new Panel();
            pane3 = new Panel();
            pict3 = new PictureBox();
            pane2 = new Panel();
            pict2 = new PictureBox();
            pane1 = new Panel();
            pictIcono = new PictureBox();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelPredeterminado.SuspendLayout();
            panel3.SuspendLayout();
            pane4.SuspendLayout();
            pane3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pict3).BeginInit();
            pane2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pict2).BeginInit();
            pane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictIcono).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(RegresarBT);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 44);
            panel1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(652, 19);
            button1.Name = "button1";
            button1.Size = new Size(117, 25);
            button1.TabIndex = 15;
            button1.Text = "Agregar Categoria";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegresarBT
            // 
            RegresarBT.BackColor = SystemColors.ActiveCaptionText;
            RegresarBT.BackgroundImageLayout = ImageLayout.None;
            RegresarBT.Cursor = Cursors.Hand;
            RegresarBT.FlatStyle = FlatStyle.Popup;
            RegresarBT.ForeColor = Color.Lime;
            RegresarBT.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            RegresarBT.IconColor = Color.Green;
            RegresarBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            RegresarBT.IconSize = 25;
            RegresarBT.ImageAlign = ContentAlignment.MiddleLeft;
            RegresarBT.Location = new Point(3, 4);
            RegresarBT.Name = "RegresarBT";
            RegresarBT.Size = new Size(37, 33);
            RegresarBT.TabIndex = 9;
            RegresarBT.TextAlign = ContentAlignment.MiddleRight;
            RegresarBT.TextImageRelation = TextImageRelation.ImageAboveText;
            RegresarBT.UseVisualStyleBackColor = false;
            RegresarBT.Click += RegresarBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(177, 5);
            label1.Name = "label1";
            label1.Size = new Size(277, 32);
            label1.TabIndex = 9;
            label1.Text = "MENU DE CATEGORIAS";
            // 
            // deprotes
            // 
            deprotes.BackColor = Color.MediumSpringGreen;
            deprotes.Cursor = Cursors.Hand;
            deprotes.IconChar = FontAwesome.Sharp.IconChar.Basketball;
            deprotes.IconColor = Color.Black;
            deprotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deprotes.ImageAlign = ContentAlignment.MiddleLeft;
            deprotes.Location = new Point(15, 99);
            deprotes.Name = "deprotes";
            deprotes.Size = new Size(123, 48);
            deprotes.TabIndex = 4;
            deprotes.Text = "Deportes";
            deprotes.TextAlign = ContentAlignment.MiddleRight;
            deprotes.UseVisualStyleBackColor = false;
            deprotes.Click += iconButton5_Click;
            // 
            // tecnologia
            // 
            tecnologia.BackColor = Color.Aqua;
            tecnologia.Cursor = Cursors.Hand;
            tecnologia.IconChar = FontAwesome.Sharp.IconChar.HeadSideVirus;
            tecnologia.IconColor = Color.Black;
            tecnologia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tecnologia.ImageAlign = ContentAlignment.MiddleLeft;
            tecnologia.Location = new Point(182, 101);
            tecnologia.Name = "tecnologia";
            tecnologia.Size = new Size(123, 48);
            tecnologia.TabIndex = 5;
            tecnologia.Text = "Tecnologia";
            tecnologia.TextAlign = ContentAlignment.MiddleRight;
            tecnologia.UseVisualStyleBackColor = false;
            tecnologia.Click += tecnologia_Click;
            // 
            // faceboock
            // 
            faceboock.BackColor = SystemColors.HotTrack;
            faceboock.Cursor = Cursors.Hand;
            faceboock.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            faceboock.IconColor = Color.Black;
            faceboock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            faceboock.IconSize = 35;
            faceboock.ImageAlign = ContentAlignment.MiddleLeft;
            faceboock.Location = new Point(15, 31);
            faceboock.Name = "faceboock";
            faceboock.Size = new Size(123, 53);
            faceboock.TabIndex = 0;
            faceboock.Text = "Redes sociales";
            faceboock.TextAlign = ContentAlignment.MiddleRight;
            faceboock.UseVisualStyleBackColor = false;
            faceboock.Click += iconButton1_Click;
            // 
            // IconAgregar_Categoria
            // 
            IconAgregar_Categoria.BackgroundImageLayout = ImageLayout.None;
            IconAgregar_Categoria.FlatStyle = FlatStyle.Flat;
            IconAgregar_Categoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IconAgregar_Categoria.ForeColor = Color.FromArgb(128, 255, 255);
            IconAgregar_Categoria.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            IconAgregar_Categoria.IconColor = Color.Cyan;
            IconAgregar_Categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconAgregar_Categoria.IconSize = 35;
            IconAgregar_Categoria.ImageAlign = ContentAlignment.BottomCenter;
            IconAgregar_Categoria.Location = new Point(8, 7);
            IconAgregar_Categoria.Name = "IconAgregar_Categoria";
            IconAgregar_Categoria.Size = new Size(127, 56);
            IconAgregar_Categoria.TabIndex = 16;
            IconAgregar_Categoria.Text = "Agregar Categoria";
            IconAgregar_Categoria.TextAlign = ContentAlignment.TopCenter;
            IconAgregar_Categoria.UseVisualStyleBackColor = true;
            IconAgregar_Categoria.Click += IconAgregar_Categoria_Click;
            // 
            // ico1
            // 
            ico1.BackColor = Color.Lime;
            ico1.IconChar = FontAwesome.Sharp.IconChar.None;
            ico1.IconColor = Color.Black;
            ico1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ico1.Location = new Point(15, 7);
            ico1.Name = "ico1";
            ico1.Size = new Size(123, 56);
            ico1.TabIndex = 17;
            ico1.Text = "iconButton10";
            ico1.TextAlign = ContentAlignment.MiddleRight;
            ico1.UseVisualStyleBackColor = false;
            ico1.Click += ico1_Click;
            // 
            // ico2
            // 
            ico2.BackColor = Color.Violet;
            ico2.IconChar = FontAwesome.Sharp.IconChar.None;
            ico2.IconColor = Color.Black;
            ico2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ico2.Location = new Point(18, 7);
            ico2.Name = "ico2";
            ico2.Size = new Size(138, 56);
            ico2.TabIndex = 18;
            ico2.Text = "iconButton11";
            ico2.TextAlign = ContentAlignment.MiddleRight;
            ico2.UseVisualStyleBackColor = false;
            ico2.Click += ico2_Click;
            // 
            // icon3
            // 
            icon3.BackColor = Color.Cyan;
            icon3.IconChar = FontAwesome.Sharp.IconChar.None;
            icon3.IconColor = Color.Black;
            icon3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon3.Location = new Point(24, 6);
            icon3.Name = "icon3";
            icon3.Size = new Size(133, 57);
            icon3.TabIndex = 19;
            icon3.Text = "iconButton12";
            icon3.TextAlign = ContentAlignment.MiddleRight;
            icon3.UseVisualStyleBackColor = false;
            icon3.Click += icon3_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.Transparent;
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatStyle = FlatStyle.Popup;
            btnRefrescar.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnRefrescar.IconColor = Color.FromArgb(0, 192, 0);
            btnRefrescar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRefrescar.IconSize = 30;
            btnRefrescar.Location = new Point(397, 1);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(44, 30);
            btnRefrescar.TabIndex = 20;
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = Color.Transparent;
            iconButton9.Cursor = Cursors.Hand;
            iconButton9.FlatStyle = FlatStyle.Popup;
            iconButton9.ForeColor = Color.Aqua;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton9.IconColor = Color.Black;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.Location = new Point(442, 3);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(136, 23);
            iconButton9.TabIndex = 23;
            iconButton9.Text = "Editar categoria";
            iconButton9.UseVisualStyleBackColor = false;
            iconButton9.Click += iconButton9_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tecnologia);
            panel2.Controls.Add(deprotes);
            panel2.Controls.Add(proyecto);
            panel2.Controls.Add(Favorito);
            panel2.Controls.Add(iconButton9);
            panel2.Controls.Add(documentacion);
            panel2.Controls.Add(Noticias);
            panel2.Controls.Add(btnRefrescar);
            panel2.Controls.Add(faceboock);
            panel2.Controls.Add(tutorial);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(626, 177);
            panel2.TabIndex = 27;
            // 
            // proyecto
            // 
            proyecto.Cursor = Cursors.Hand;
            proyecto.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            proyecto.IconColor = Color.Black;
            proyecto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            proyecto.ImageAlign = ContentAlignment.MiddleLeft;
            proyecto.Location = new Point(347, 103);
            proyecto.Name = "proyecto";
            proyecto.Size = new Size(111, 48);
            proyecto.TabIndex = 6;
            proyecto.Text = "Proyectos";
            proyecto.TextAlign = ContentAlignment.MiddleRight;
            proyecto.UseVisualStyleBackColor = true;
            proyecto.Click += proyecto_Click;
            // 
            // Favorito
            // 
            Favorito.BackColor = Color.Yellow;
            Favorito.Cursor = Cursors.Hand;
            Favorito.IconChar = FontAwesome.Sharp.IconChar.GrinWink;
            Favorito.IconColor = Color.Black;
            Favorito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Favorito.ImageAlign = ContentAlignment.MiddleLeft;
            Favorito.Location = new Point(347, 35);
            Favorito.Name = "Favorito";
            Favorito.Size = new Size(111, 53);
            Favorito.TabIndex = 2;
            Favorito.Text = "Favoritos";
            Favorito.TextAlign = ContentAlignment.MiddleRight;
            Favorito.UseVisualStyleBackColor = false;
            Favorito.Click += iconButton3_Click;
            // 
            // documentacion
            // 
            documentacion.BackColor = SystemColors.ControlDark;
            documentacion.Cursor = Cursors.Hand;
            documentacion.IconChar = FontAwesome.Sharp.IconChar.FileArrowDown;
            documentacion.IconColor = Color.Black;
            documentacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            documentacion.ImageAlign = ContentAlignment.TopCenter;
            documentacion.Location = new Point(480, 91);
            documentacion.Name = "documentacion";
            documentacion.Size = new Size(123, 66);
            documentacion.TabIndex = 7;
            documentacion.Text = "Documentación";
            documentacion.TextAlign = ContentAlignment.BottomCenter;
            documentacion.UseVisualStyleBackColor = false;
            documentacion.Click += iconButton8_Click;
            // 
            // Noticias
            // 
            Noticias.BackColor = Color.OrangeRed;
            Noticias.Cursor = Cursors.Hand;
            Noticias.IconChar = FontAwesome.Sharp.IconChar.Passport;
            Noticias.IconColor = Color.Black;
            Noticias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Noticias.ImageAlign = ContentAlignment.MiddleLeft;
            Noticias.Location = new Point(182, 32);
            Noticias.Name = "Noticias";
            Noticias.Size = new Size(123, 53);
            Noticias.TabIndex = 1;
            Noticias.Text = "Noticias";
            Noticias.TextAlign = ContentAlignment.MiddleRight;
            Noticias.UseVisualStyleBackColor = false;
            Noticias.Click += iconButton2_Click;
            // 
            // tutorial
            // 
            tutorial.BackColor = Color.DarkSeaGreen;
            tutorial.Cursor = Cursors.Hand;
            tutorial.IconChar = FontAwesome.Sharp.IconChar.TabletScreenButton;
            tutorial.IconColor = Color.Black;
            tutorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tutorial.ImageAlign = ContentAlignment.MiddleLeft;
            tutorial.Location = new Point(480, 30);
            tutorial.Name = "tutorial";
            tutorial.Size = new Size(123, 54);
            tutorial.TabIndex = 3;
            tutorial.Text = "Tutoriales";
            tutorial.TextAlign = ContentAlignment.MiddleRight;
            tutorial.UseVisualStyleBackColor = false;
            tutorial.Click += tutorial_Click;
            // 
            // PanelPredeterminado
            // 
            PanelPredeterminado.BackColor = Color.Transparent;
            PanelPredeterminado.Controls.Add(panel3);
            PanelPredeterminado.Controls.Add(panel2);
            PanelPredeterminado.Dock = DockStyle.Fill;
            PanelPredeterminado.Location = new Point(0, 44);
            PanelPredeterminado.Name = "PanelPredeterminado";
            PanelPredeterminado.Size = new Size(626, 350);
            PanelPredeterminado.TabIndex = 10;
            PanelPredeterminado.Paint += PanelPredeterminado_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(pane4);
            panel3.Controls.Add(pane3);
            panel3.Controls.Add(pane2);
            panel3.Controls.Add(pane1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 177);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 126);
            panel3.TabIndex = 28;
            // 
            // pane4
            // 
            pane4.Controls.Add(IconAgregar_Categoria);
            pane4.Dock = DockStyle.Left;
            pane4.Location = new Point(490, 0);
            pane4.Name = "pane4";
            pane4.Size = new Size(136, 126);
            pane4.TabIndex = 30;
            // 
            // pane3
            // 
            pane3.Controls.Add(pict3);
            pane3.Controls.Add(icon3);
            pane3.Dock = DockStyle.Left;
            pane3.Location = new Point(323, 0);
            pane3.Name = "pane3";
            pane3.Size = new Size(167, 126);
            pane3.TabIndex = 29;
            // 
            // pict3
            // 
            pict3.BackColor = Color.Cyan;
            pict3.Location = new Point(35, 19);
            pict3.Name = "pict3";
            pict3.Size = new Size(40, 31);
            pict3.SizeMode = PictureBoxSizeMode.StretchImage;
            pict3.TabIndex = 27;
            pict3.TabStop = false;
            // 
            // pane2
            // 
            pane2.Controls.Add(pict2);
            pane2.Controls.Add(ico2);
            pane2.Dock = DockStyle.Left;
            pane2.Location = new Point(156, 0);
            pane2.Name = "pane2";
            pane2.Size = new Size(167, 126);
            pane2.TabIndex = 28;
            // 
            // pict2
            // 
            pict2.BackColor = Color.Violet;
            pict2.Location = new Point(26, 19);
            pict2.Name = "pict2";
            pict2.Size = new Size(40, 31);
            pict2.SizeMode = PictureBoxSizeMode.StretchImage;
            pict2.TabIndex = 27;
            pict2.TabStop = false;
            // 
            // pane1
            // 
            pane1.Controls.Add(pictIcono);
            pane1.Controls.Add(ico1);
            pane1.Dock = DockStyle.Left;
            pane1.Location = new Point(0, 0);
            pane1.Name = "pane1";
            pane1.Size = new Size(156, 126);
            pane1.TabIndex = 27;
            // 
            // pictIcono
            // 
            pictIcono.BackColor = Color.Lime;
            pictIcono.Location = new Point(24, 19);
            pictIcono.Name = "pictIcono";
            pictIcono.Size = new Size(40, 31);
            pictIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pictIcono.TabIndex = 25;
            pictIcono.TabStop = false;
            // 
            // PanCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(626, 394);
            Controls.Add(PanelPredeterminado);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PanCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanCategoria";
            Load += PanCategoria_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            PanelPredeterminado.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pane4.ResumeLayout(false);
            pane3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pict3).EndInit();
            pane2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pict2).EndInit();
            pane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictIcono).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton RegresarBT;
        private Button button1;
        private FontAwesome.Sharp.IconButton deprotes;
        private FontAwesome.Sharp.IconButton tecnologia;
        private FontAwesome.Sharp.IconButton faceboock;
        private FontAwesome.Sharp.IconButton IconAgregar_Categoria;
        private FontAwesome.Sharp.IconButton ico1;
        private FontAwesome.Sharp.IconButton ico2;
        private FontAwesome.Sharp.IconButton icon3;
        private FontAwesome.Sharp.IconButton btnRefrescar;
        private FontAwesome.Sharp.IconButton iconButton9;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton proyecto;
        private FontAwesome.Sharp.IconButton Favorito;
        private FontAwesome.Sharp.IconButton documentacion;
        private FontAwesome.Sharp.IconButton Noticias;
        private FontAwesome.Sharp.IconButton tutorial;
        private Panel PanelPredeterminado;
        private Panel panel3;
        private Panel pane2;
        private Panel pane1;
        private PictureBox pictIcono;
        private Panel pane4;
        private Panel pane3;
        private PictureBox pict3;
        private PictureBox pict2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}