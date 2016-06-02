using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProcesadorImagenes
{
    public partial class Main : Form
    {
        Bitmap imagen_original;
        public Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para abrir una imagen
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {// height es fila y width es columna
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
                    string colores = "{";
                    for (int i = 0; i < image.Width; i++)
                    {
                        for (int j = 0; j < image.Height; j++)
                        {
                            colores += "(" + image.GetPixel(i, j).R.ToString() + "," + image.GetPixel(i, j).G.ToString() 
                                + "," + image.GetPixel(i, j).B.ToString()+ "), ";
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
        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Efectos foto = new Efectos(image);

            pictureBox1.Image = foto.EscalaGris();
        }

        // Rotar 90 grados a la izquierda
        private void izquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap imagetrans = new Bitmap(image.Height, image.Width);
            Bitmap imagerot = new Bitmap(image.Height, image.Width);
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    imagetrans.SetPixel(j, i, image.GetPixel(i, j));

            for (int i = 0; i < imagerot.Width; i++)
                for (int j = 0; j < imagerot.Height; j++)
                    imagerot.SetPixel(i, (imagerot.Height - 1 - j), imagetrans.GetPixel(i, j));
            pictureBox1.Image = imagerot;
        }

        // Rotar 90 grados a la derecha
        private void derecha90_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap imagetrans = new Bitmap(image.Height, image.Width);
            Bitmap imagerot = new Bitmap(image.Height, image.Width);
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    imagetrans.SetPixel(j, i, image.GetPixel(i, j));

            for (int i = 0; i < imagerot.Width; i++)
                for (int j = 0; j < imagerot.Height; j++)
                    imagerot.SetPixel((imagerot.Width - 1 - i), j, imagetrans.GetPixel(i, j));
            pictureBox1.Image = imagerot;
        }

        // Efecto escala de ROJOS
        private void escalaDeRojosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Efectos foto = new Efectos(image);
            pictureBox1.Image = foto.EscalaRojo();
        }

        // Efecto escala de AZULES
        private void escalaDeAzulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Efectos foto = new Efectos(image);

            pictureBox1.Image = foto.EscalaAzul();

        }

        // Efecto escala de VERDES
        private void escalaDeVerdesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Efectos foto = new Efectos(image);

            pictureBox1.Image = foto.EscalaVerde();
        }

        // Reestablece la imagen a su forma original
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imagen_original;
        }

        // Convierte a la imagen en negativo
        private void negativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Efectos foto = new Efectos(image);

            pictureBox1.Image = foto.Negativo();
        }

        // Efecto espejo sobre la imagen
        private void reflejoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // height es fila y width es columna
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap imagerot = new Bitmap(image.Width, image.Height);
            for (int i = 0; i < image.Width; i++)
                for (int j = 0; j < image.Height; j++)
                    imagerot.SetPixel(image.Width-1-i, j, image.GetPixel(i, j));

            pictureBox1.Image = imagerot;
        }

        // Método para guardar la imagen
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            SaveFileDialog sfd = new SaveFileDialog();
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }
        }

        //Efecto "blur"
        private void efectoBlur(object sender, EventArgs e)
        {
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
        private void BarraBlur_Scroll_1(object sender, EventArgs e)
        {
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
        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        private void barraCanalRojo_Scroll(object sender, EventArgs e)
        {
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
        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        private void barraCanalVerde_Scroll(object sender, EventArgs e)
        {
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
        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        private void barraCanalAzul_Scroll(object sender, EventArgs e)
        {
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
        private void BrilloBoton_Click(object sender, EventArgs e)
        {
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
        private void barraBrillo_Scroll(object sender, EventArgs e)
        {
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
}
