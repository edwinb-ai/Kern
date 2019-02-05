//
// Translated by CS2J (http://www.cs2j.com): 2/4/2019 9:18:40 PM
//

package ProcesadorImagenes;

import CS2JNet.JavaSupport.language.EventArgs;
import ProcesadorImagenes.Efectos;

public class Main  extends Form 
{

    /**
    * Required designer variable.
    */
    private System.ComponentModel.IContainer components = null;
    /**
    * Clean up any resources being used.
    * 
    *  @param disposing true if managed resources should be disposed; otherwise, false.
    */
    protected void dispose(boolean disposing) throws Exception {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
         
        super.Dispose(disposing);
    }

    /**
    * Required method for Designer support - do not modify
    * the contents of this method with the code editor.
    */
    private void initializeComponent() throws Exception {
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
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.archivoToolStripMenuItem, this.filtrosToolStripMenuItem, this.transformarToolStripMenuItem });
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Size = new System.Drawing.Size(655, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        //
        // archivoToolStripMenuItem
        //
        this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.abrirToolStripMenuItem, this.guardarToolStripMenuItem, this.inicioToolStripMenuItem, this.salirToolStripMenuItem });
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
        this.filtrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.escalaDeGrisesToolStripMenuItem, this.negativoToolStripMenuItem, this.escalaDeRojosToolStripMenuItem, this.escalaDeAzulesToolStripMenuItem, this.escalaDeVerdesToolStripMenuItem, this.BlurButton, this.canalRojo, this.BrilloBoton });
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
        this.canalRojo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.botonRojo, this.botonVerde, this.botonAzul });
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
        this.transformarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.rotarToolStripMenuItem, this.reflejoToolStripMenuItem });
        this.transformarToolStripMenuItem.Name = "transformarToolStripMenuItem";
        this.transformarToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
        this.transformarToolStripMenuItem.Text = "Transformar";
        this.transformarToolStripMenuItem.Visible = false;
        //
        // rotarToolStripMenuItem
        //
        this.rotarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{ this.derecha90, this.izquierdaToolStripMenuItem });
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

    private System.Windows.Forms.MenuStrip menuStrip1 = new System.Windows.Forms.MenuStrip();
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
    private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem transformarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem rotarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem escalaDeRojosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem escalaDeAzulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem escalaDeVerdesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem reflejoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem izquierdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem derecha90 = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem BlurButton = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.TrackBar BarraBlur = new System.Windows.Forms.TrackBar();
    private System.Windows.Forms.ToolStripMenuItem canalRojo = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem botonRojo = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem botonVerde = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem botonAzul = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.ToolStripMenuItem BrilloBoton = new System.Windows.Forms.ToolStripMenuItem();
    private System.Windows.Forms.TrackBar barraBrillo = new System.Windows.Forms.TrackBar();
    private System.Windows.Forms.TrackBar barraCanalRojo = new System.Windows.Forms.TrackBar();
    private System.Windows.Forms.TrackBar barraCanalVerde = new System.Windows.Forms.TrackBar();
    private System.Windows.Forms.TrackBar barraCanalAzul = new System.Windows.Forms.TrackBar();
    Bitmap imagen_original = new Bitmap();
    public Main() throws Exception {
        initializeComponent();
    }

    private void salirToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        this.Close();
    }

    // Método para abrir una imagen
    private void abrirToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        // height es fila y width es columna
        OpenFileDialog of = new OpenFileDialog();
        of.Title = "Elige una imagen";
        of.Filter = "Archivo Imagen(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
        if (of.ShowDialog() == DialogResult.OK)
        {
            imagen_original = new Bitmap(of.OpenFile());
            Bitmap image = new Bitmap(of.OpenFile());
            pictureBox1.Image = image;
            if (image.Width < 20)
            {
                String colores = "{";
                for (int i = 0;i < image.Width;i++)
                {
                    for (int j = 0;j < image.Height;j++)
                    {
                        colores += "(" + image.GetPixel(i, j).R.toString() + "," + image.GetPixel(i, j).G.toString() + "," + image.GetPixel(i, j).B.toString() + "), ";
                    }
                    colores += "\n";
                }
                MessageBox.Show(colores + "}");
            }
             
            guardarToolStripMenuItem.Enabled = true;
            filtrosToolStripMenuItem.Visible = true;
            transformarToolStripMenuItem.Visible = true;
        }
         
    }

    // Efecto escala de GRISES
    private void escalaDeGrisesToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Efectos foto = new Efectos(image);
        pictureBox1.Image = foto.escalaGris();
    }

    // Rotar 90 grados a la izquierda
    private void izquierdaToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Bitmap imagetrans = new Bitmap(image.Height, image.Width);
        Bitmap imagerot = new Bitmap(image.Height, image.Width);
        for (int i = 0;i < image.Width;i++)
            for (int j = 0;j < image.Height;j++)
                imagetrans.SetPixel(j, i, image.GetPixel(i, j));
        for (int i = 0;i < imagerot.Width;i++)
            for (int j = 0;j < imagerot.Height;j++)
                imagerot.SetPixel(i, (imagerot.Height - 1 - j), imagetrans.GetPixel(i, j));
        pictureBox1.Image = imagerot;
    }

    // Rotar 90 grados a la derecha
    private void derecha90_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Bitmap imagetrans = new Bitmap(image.Height, image.Width);
        Bitmap imagerot = new Bitmap(image.Height, image.Width);
        for (int i = 0;i < image.Width;i++)
            for (int j = 0;j < image.Height;j++)
                imagetrans.SetPixel(j, i, image.GetPixel(i, j));
        for (int i = 0;i < imagerot.Width;i++)
            for (int j = 0;j < imagerot.Height;j++)
                imagerot.SetPixel((imagerot.Width - 1 - i), j, imagetrans.GetPixel(i, j));
        pictureBox1.Image = imagerot;
    }

    // Efecto escala de ROJOS
    private void escalaDeRojosToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Efectos foto = new Efectos(image);
        pictureBox1.Image = foto.escalaRojo();
    }

    // Efecto escala de AZULES
    private void escalaDeAzulesToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Efectos foto = new Efectos(image);
        pictureBox1.Image = foto.escalaAzul();
    }

    // Efecto escala de VERDES
    private void escalaDeVerdesToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Efectos foto = new Efectos(image);
        pictureBox1.Image = foto.escalaVerde();
    }

    // Reestablece la imagen a su forma original
    private void inicioToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        pictureBox1.Image = imagen_original;
    }

    // Convierte a la imagen en negativo
    private void negativoToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        Efectos foto = new Efectos(image);
        pictureBox1.Image = foto.negativo();
    }

    // Efecto espejo sobre la imagen
    private void reflejoToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        // height es fila y width es columna
        Bitmap image = new Bitmap(pictureBox1.Image);
        Bitmap imagerot = new Bitmap(image.Width, image.Height);
        for (int i = 0;i < image.Width;i++)
            for (int j = 0;j < image.Height;j++)
                imagerot.SetPixel(image.Width - 1 - i, j, image.GetPixel(i, j));
        pictureBox1.Image = imagerot;
    }

    // Método para guardar la imagen
    private void guardarToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        Bitmap image = new Bitmap(pictureBox1.Image);
        SaveFileDialog sfd = new SaveFileDialog();
        System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
        sfd.Filter = "Images|*.png;*.bmp;*.jpg";
        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            String ext = Path.GetExtension(sfd.FileName);
            String __dummyScrutVar0 = ext;
            if (__dummyScrutVar0.equals(".jpg"))
            {
                format = System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            else if (__dummyScrutVar0.equals(".bmp"))
            {
                format = System.Drawing.Imaging.ImageFormat.Bmp;
            }
              
            pictureBox1.Image.Save(sfd.FileName, format);
        }
         
    }

    //Efecto "blur"
    private void efectoBlur(Object sender, EventArgs e) throws Exception {
        // Activar barra para blur
        if (BlurButton.Checked == true)
        {
            BarraBlur.Value = 0;
            BarraBlur.Visible = true;
            BarraBlur.Enabled = true;
        }
        else
        {
            BarraBlur.Value = 0;
            BarraBlur.Visible = false;
            BarraBlur.Enabled = false;
        } 
    }

    private void barraBlur_Scroll_1(Object sender, EventArgs e) throws Exception {
        //Bitmap imagen = new Bitmap(pictureBox1.Image);
        //Efectos foto = new Efectos(image);
        if (BarraBlur.Value == 0)
        {
            pictureBox1.Image = imagen_original;
        }
        else
        {
            Efectos foto = new Efectos(imagen_original);
            pictureBox1.Image = foto.BlurEffect(BarraBlur.Value);
        } 
    }

    // Ajustes de canal
    // Rojo
    private void rojoToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        if (botonRojo.Checked == true)
        {
            barraCanalRojo.Value = 0;
            barraCanalRojo.Enabled = true;
            barraCanalRojo.Visible = true;
        }
        else
        {
            barraCanalRojo.Value = 0;
            barraCanalRojo.Enabled = false;
            barraCanalRojo.Visible = false;
        } 
    }

    private void barraCanalRojo_Scroll(Object sender, EventArgs e) throws Exception {
        if (barraCanalRojo.Value == 0)
        {
            pictureBox1.Image = imagen_original;
        }
        else
        {
            Efectos foto = new Efectos(imagen_original);
            pictureBox1.Image = foto.CanalRojo(barraCanalRojo.Value);
        } 
    }

    // Verde
    private void verdeToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        if (botonVerde.Checked == true)
        {
            barraCanalVerde.Value = 0;
            barraCanalVerde.Enabled = true;
            barraCanalVerde.Visible = true;
        }
        else
        {
            barraCanalVerde.Value = 0;
            barraCanalVerde.Enabled = false;
            barraCanalVerde.Visible = false;
        } 
    }

    private void barraCanalVerde_Scroll(Object sender, EventArgs e) throws Exception {
        if (barraCanalVerde.Value == 0)
        {
            pictureBox1.Image = imagen_original;
        }
        else
        {
            Efectos foto = new Efectos(imagen_original);
            pictureBox1.Image = foto.CanalVerde(barraCanalVerde.Value);
        } 
    }

    // Azul
    private void azulToolStripMenuItem_Click(Object sender, EventArgs e) throws Exception {
        if (botonAzul.Checked == true)
        {
            barraCanalAzul.Value = 0;
            barraCanalAzul.Enabled = true;
            barraCanalAzul.Visible = true;
        }
        else
        {
            barraCanalAzul.Value = 0;
            barraCanalAzul.Enabled = false;
            barraCanalAzul.Visible = false;
        } 
    }

    private void barraCanalAzul_Scroll(Object sender, EventArgs e) throws Exception {
        if (barraCanalAzul.Value == 0)
        {
            pictureBox1.Image = imagen_original;
        }
        else
        {
            Efectos foto = new Efectos(imagen_original);
            pictureBox1.Image = foto.CanalAzul(barraCanalAzul.Value);
        } 
    }

    // Brillo de imagen
    private void brilloBoton_Click(Object sender, EventArgs e) throws Exception {
        if (BrilloBoton.Checked == true)
        {
            barraBrillo.Value = 0;
            barraBrillo.Visible = true;
            barraBrillo.Enabled = true;
        }
        else
        {
            barraBrillo.Value = 0;
            barraBrillo.Visible = false;
            barraBrillo.Enabled = false;
        } 
    }

    private void barraBrillo_Scroll(Object sender, EventArgs e) throws Exception {
        //Bitmap imagen = new Bitmap(pictureBox1.Image);
        if (barraBrillo.Value == 0)
        {
            pictureBox1.Image = imagen_original;
        }
        else
        {
            Efectos foto = new Efectos(imagen_original);
            pictureBox1.Image = foto.Brillo(barraBrillo.Value);
        } 
    }

}


