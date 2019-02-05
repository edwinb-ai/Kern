
namespace ProcesadorImagenes
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeRojosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeAzulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeVerdesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlurButton = new System.Windows.Forms.ToolStripMenuItem();
            this.canalRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.botonRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.botonVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.botonAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.BrilloBoton = new System.Windows.Forms.ToolStripMenuItem();
            this.transformarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derecha90 = new System.Windows.Forms.ToolStripMenuItem();
            this.izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraBlur = new System.Windows.Forms.TrackBar();
            this.barraBrillo = new System.Windows.Forms.TrackBar();
            this.barraCanalRojo = new System.Windows.Forms.TrackBar();
            this.barraCanalVerde = new System.Windows.Forms.TrackBar();
            this.barraCanalAzul = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBrillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalAzul)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.transformarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.inicioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escalaDeGrisesToolStripMenuItem,
            this.negativoToolStripMenuItem,
            this.escalaDeRojosToolStripMenuItem,
            this.escalaDeAzulesToolStripMenuItem,
            this.escalaDeVerdesToolStripMenuItem,
            this.BlurButton,
            this.canalRojo,
            this.BrilloBoton});
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            this.filtrosToolStripMenuItem.Visible = false;
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // negativoToolStripMenuItem
            // 
            this.negativoToolStripMenuItem.Name = "negativoToolStripMenuItem";
            this.negativoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.negativoToolStripMenuItem.Text = "Negativo";
            this.negativoToolStripMenuItem.Click += new System.EventHandler(this.negativoToolStripMenuItem_Click);
            // 
            // escalaDeRojosToolStripMenuItem
            // 
            this.escalaDeRojosToolStripMenuItem.Name = "escalaDeRojosToolStripMenuItem";
            this.escalaDeRojosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.escalaDeRojosToolStripMenuItem.Text = "Escala de Rojos";
            this.escalaDeRojosToolStripMenuItem.Click += new System.EventHandler(this.escalaDeRojosToolStripMenuItem_Click);
            // 
            // escalaDeAzulesToolStripMenuItem
            // 
            this.escalaDeAzulesToolStripMenuItem.Name = "escalaDeAzulesToolStripMenuItem";
            this.escalaDeAzulesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.escalaDeAzulesToolStripMenuItem.Text = "Escala de Azules";
            this.escalaDeAzulesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeAzulesToolStripMenuItem_Click);
            // 
            // escalaDeVerdesToolStripMenuItem
            // 
            this.escalaDeVerdesToolStripMenuItem.Name = "escalaDeVerdesToolStripMenuItem";
            this.escalaDeVerdesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.escalaDeVerdesToolStripMenuItem.Text = "Escala de Verdes";
            this.escalaDeVerdesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeVerdesToolStripMenuItem_Click);
            // 
            // BlurButton
            // 
            this.BlurButton.CheckOnClick = true;
            this.BlurButton.Name = "BlurButton";
            this.BlurButton.Size = new System.Drawing.Size(161, 22);
            this.BlurButton.Text = "Blur";
            this.BlurButton.Click += new System.EventHandler(this.efectoBlur);
            // 
            // canalRojo
            // 
            this.canalRojo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonRojo,
            this.botonVerde,
            this.botonAzul});
            this.canalRojo.Name = "canalRojo";
            this.canalRojo.Size = new System.Drawing.Size(161, 22);
            this.canalRojo.Text = "Ajustes de Canal";
            // 
            // botonRojo
            // 
            this.botonRojo.CheckOnClick = true;
            this.botonRojo.Name = "botonRojo";
            this.botonRojo.Size = new System.Drawing.Size(152, 22);
            this.botonRojo.Text = "Rojo";
            this.botonRojo.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // botonVerde
            // 
            this.botonVerde.CheckOnClick = true;
            this.botonVerde.Name = "botonVerde";
            this.botonVerde.Size = new System.Drawing.Size(152, 22);
            this.botonVerde.Text = "Verde";
            this.botonVerde.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // botonAzul
            // 
            this.botonAzul.CheckOnClick = true;
            this.botonAzul.Name = "botonAzul";
            this.botonAzul.Size = new System.Drawing.Size(152, 22);
            this.botonAzul.Text = "Azul";
            this.botonAzul.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // BrilloBoton
            // 
            this.BrilloBoton.CheckOnClick = true;
            this.BrilloBoton.Name = "BrilloBoton";
            this.BrilloBoton.Size = new System.Drawing.Size(161, 22);
            this.BrilloBoton.Text = "Brillo";
            this.BrilloBoton.Click += new System.EventHandler(this.BrilloBoton_Click);
            // 
            // transformarToolStripMenuItem
            // 
            this.transformarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotarToolStripMenuItem,
            this.reflejoToolStripMenuItem});
            this.transformarToolStripMenuItem.Name = "transformarToolStripMenuItem";
            this.transformarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.transformarToolStripMenuItem.Text = "Transformar";
            this.transformarToolStripMenuItem.Visible = false;
            // 
            // rotarToolStripMenuItem
            // 
            this.rotarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derecha90,
            this.izquierdaToolStripMenuItem});
            this.rotarToolStripMenuItem.Name = "rotarToolStripMenuItem";
            this.rotarToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.rotarToolStripMenuItem.Text = "Rotar";
            // 
            // derecha90
            // 
            this.derecha90.Name = "derecha90";
            this.derecha90.Size = new System.Drawing.Size(145, 22);
            this.derecha90.Text = "90 (derecha)";
            this.derecha90.Click += new System.EventHandler(this.derecha90_Click);
            // 
            // izquierdaToolStripMenuItem
            // 
            this.izquierdaToolStripMenuItem.Name = "izquierdaToolStripMenuItem";
            this.izquierdaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.izquierdaToolStripMenuItem.Text = "90 (izquierda)";
            this.izquierdaToolStripMenuItem.Click += new System.EventHandler(this.izquierdaToolStripMenuItem_Click);
            // 
            // reflejoToolStripMenuItem
            // 
            this.reflejoToolStripMenuItem.Name = "reflejoToolStripMenuItem";
            this.reflejoToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reflejoToolStripMenuItem.Text = "Reflejo";
            this.reflejoToolStripMenuItem.Click += new System.EventHandler(this.reflejoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BarraBlur
            // 
            this.BarraBlur.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraBlur.Enabled = false;
            this.BarraBlur.LargeChange = 3;
            this.BarraBlur.Location = new System.Drawing.Point(0, 24);
            this.BarraBlur.Maximum = 5;
            this.BarraBlur.Name = "BarraBlur";
            this.BarraBlur.Size = new System.Drawing.Size(655, 45);
            this.BarraBlur.TabIndex = 2;
            this.BarraBlur.Visible = false;
            this.BarraBlur.Scroll += new System.EventHandler(this.BarraBlur_Scroll_1);
            // 
            // barraBrillo
            // 
            this.barraBrillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraBrillo.Enabled = false;
            this.barraBrillo.LargeChange = 40;
            this.barraBrillo.Location = new System.Drawing.Point(0, 69);
            this.barraBrillo.Maximum = 100;
            this.barraBrillo.Minimum = -100;
            this.barraBrillo.Name = "barraBrillo";
            this.barraBrillo.Size = new System.Drawing.Size(655, 45);
            this.barraBrillo.SmallChange = 20;
            this.barraBrillo.TabIndex = 2;
            this.barraBrillo.TickFrequency = 20;
            this.barraBrillo.Visible = false;
            this.barraBrillo.Scroll += new System.EventHandler(this.barraBrillo_Scroll);
            // 
            // barraCanalRojo
            // 
            this.barraCanalRojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraCanalRojo.Enabled = false;
            this.barraCanalRojo.Location = new System.Drawing.Point(0, 114);
            this.barraCanalRojo.Maximum = 100;
            this.barraCanalRojo.Name = "barraCanalRojo";
            this.barraCanalRojo.Size = new System.Drawing.Size(655, 45);
            this.barraCanalRojo.TabIndex = 3;
            this.barraCanalRojo.Visible = false;
            this.barraCanalRojo.Scroll += new System.EventHandler(this.barraCanalRojo_Scroll);
            // 
            // barraCanalVerde
            // 
            this.barraCanalVerde.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraCanalVerde.Enabled = false;
            this.barraCanalVerde.Location = new System.Drawing.Point(0, 159);
            this.barraCanalVerde.Maximum = 100;
            this.barraCanalVerde.Name = "barraCanalVerde";
            this.barraCanalVerde.Size = new System.Drawing.Size(655, 45);
            this.barraCanalVerde.TabIndex = 4;
            this.barraCanalVerde.Visible = false;
            this.barraCanalVerde.Scroll += new System.EventHandler(this.barraCanalVerde_Scroll);
            // 
            // barraCanalAzul
            // 
            this.barraCanalAzul.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraCanalAzul.Enabled = false;
            this.barraCanalAzul.Location = new System.Drawing.Point(0, 204);
            this.barraCanalAzul.Maximum = 100;
            this.barraCanalAzul.Name = "barraCanalAzul";
            this.barraCanalAzul.Size = new System.Drawing.Size(655, 45);
            this.barraCanalAzul.TabIndex = 5;
            this.barraCanalAzul.Visible = false;
            this.barraCanalAzul.Scroll += new System.EventHandler(this.barraCanalAzul_Scroll);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(655, 476);
            this.Controls.Add(this.barraCanalAzul);
            this.Controls.Add(this.barraCanalVerde);
            this.Controls.Add(this.barraCanalRojo);
            this.Controls.Add(this.barraBrillo);
            this.Controls.Add(this.BarraBlur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Procesador de Imagenes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarraBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBrillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraCanalAzul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeRojosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeAzulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeVerdesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflejoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derecha90;
        private System.Windows.Forms.ToolStripMenuItem BlurButton;
        private System.Windows.Forms.TrackBar BarraBlur;
        private System.Windows.Forms.ToolStripMenuItem canalRojo;
        private System.Windows.Forms.ToolStripMenuItem botonRojo;
        private System.Windows.Forms.ToolStripMenuItem botonVerde;
        private System.Windows.Forms.ToolStripMenuItem botonAzul;
        private System.Windows.Forms.ToolStripMenuItem BrilloBoton;
        private System.Windows.Forms.TrackBar barraBrillo;
        private System.Windows.Forms.TrackBar barraCanalRojo;
        private System.Windows.Forms.TrackBar barraCanalVerde;
        private System.Windows.Forms.TrackBar barraCanalAzul;
    }
}

