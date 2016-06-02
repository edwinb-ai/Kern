using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProcesadorImagenes
{
    class Efectos
    {

        private Bitmap imagen;
        private float variable;
        private int numero;

        // Constructor default
        public Efectos(Bitmap item)
        {
            imagen = item;
        }

        // Truncar
        private int Truncar(int valor)
        {
            if (valor < 0)
            {
                valor = 0;
            }
            if (valor > 255)
            {
                valor = 255;
            }

            return valor;
        }
        
        // Negativo
        public Bitmap Negativo()
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    Color pixelColor = imagen.GetPixel(i, j);
                    int r = Truncar((int)(255 - pixelColor.R));
                    int g = Truncar((int)(255 - pixelColor.G));
                    int b = Truncar((int)(255 - pixelColor.B));
                    Color newColor = Color.FromArgb(r, g, b);
                    imagen.SetPixel(i, j, newColor);
                }
            }

            return imagen;
        }

        // Brillo
        public Bitmap Brillo(int valor_p)
        {
            var copy = (Bitmap) imagen.Clone();
            
            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    Color pixelColor = copy.GetPixel(i, j);
                    int r = Truncar(pixelColor.R + valor_p);
                    int g = Truncar(pixelColor.G + valor_p);
                    int b = Truncar(pixelColor.B + valor_p);
                    Color newColor = Color.FromArgb(r, g, b);
                    copy.SetPixel(i, j, newColor);
                }
            }

            return copy;
        }

        // Efecto Blur
        public Bitmap BlurEffect(int profundidad)
        {
            var copy = (Bitmap)imagen.Clone();

            for (int k = 0; k < profundidad; k++)
            {
                for (int i = 2; i < copy.Width; i++)
                {
                    for (int j = 2; j < copy.Height; j++)
                    {
                        try
                        {
                            // Pixeles a la izquierda del pixel central, eje 'x+'
                            Color antX1 = copy.GetPixel(i - 1, j);
                            Color antX2 = copy.GetPixel(i - 2, j);
                            // Pixeles a la derecha del pixel central, eje 'x-'
                            Color desX1 = copy.GetPixel(i + 1, j);
                            Color desX2 = copy.GetPixel(i + 2, j);
                            // Pixeles arriba del pixel central, eje 'y+'
                            Color antY1 = copy.GetPixel(i, j - 1);
                            Color antY2 = copy.GetPixel(i, j - 2);
                            // Pixeles abajo del pixel central, eje 'y-'
                            Color desY1 = copy.GetPixel(i, j + 1);
                            Color desY2 = copy.GetPixel(i, j + 2);

                            // Promedio de todos los pixeles incluido el central
                            int promR = (int)((antX1.R + antX2.R + desX1.R + desX2.R + antY1.R + antY2.R + desY1.R + desY2.R + copy.GetPixel(i, j).R) / 9);
                            int promG = (int)((antX1.G + antX2.G + desX1.G + desX2.G + antY1.G + antY2.G + desY1.G + desY2.G + copy.GetPixel(i, j).G) / 9);
                            int promB = (int)((antX1.B + antX2.B + desX1.B + desX2.B + antY1.B + antY2.B + desY1.B + desY2.B + copy.GetPixel(i, j).B) / 9);

                            // Utilizar los nuevos promedios como el color de cada pixel
                            copy.SetPixel(i, j, Color.FromArgb(promR, promG, promB));
                        }
                        catch (Exception)
                        {
                            
                        }


                    }
                }
            }

            return copy;
        }

        // Escalas de color
        // Rojo
        // Efecto Blur, versión más rápida
        //public Bitmap BlurEffect(int profundidad)
        //{
        //    var copy = (Bitmap)imagen.Clone();
        //    var copyData = new DirectBitmap(copy.Width, copy.Height);
        //    for (int i = 0; i < profundidad; i++)
        //    {
        //        for (int j = 2; j < copyData.Bits.Length; j++)
        //        {
        //            copyData.Bits[]
        //        }
        //    }
        //}
        public Bitmap EscalaRojo()
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    Color pixelColor = imagen.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.299) + (pixelColor.G * 0.587) + (pixelColor.B * .114));
                    Color newColor = Color.FromArgb(grayScale, 0, 0);
                    imagen.SetPixel(i, j, newColor);
                }
            }

            return imagen;
        }
        // Azul
        public Bitmap EscalaAzul()
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    Color pixelColor = imagen.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.299) + (pixelColor.G * 0.587) + (pixelColor.B * .114));
                    Color newColor = Color.FromArgb(0, 0, grayScale);
                    imagen.SetPixel(i, j, newColor);
                }
            }

            return imagen;
        }
        // Verde
        public Bitmap EscalaVerde()
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    Color pixelColor = imagen.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.299) + (pixelColor.G * 0.587) + (pixelColor.B * .114));
                    Color newColor = Color.FromArgb(0, grayScale, 0);
                    imagen.SetPixel(i, j, newColor);
                }
            }

            return imagen;
        }
        // Grises
        public Bitmap EscalaGris()
        {
            for (int i = 0; i < imagen.Width; i++)
            {
                for (int j = 0; j < imagen.Height; j++)
                {
                    Color pixelColor = imagen.GetPixel(i, j);
                    int grayScale = (int)((pixelColor.R * 0.299) + (pixelColor.G * 0.587) + (pixelColor.B * .114));
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    imagen.SetPixel(i, j, newColor);
                }
            }

            return imagen;
        }
        // Ajustes de Canal
        // Rojo
        public Bitmap CanalRojo(int valor_p)
        {
            var copy = (Bitmap)imagen.Clone();
            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    Color pixelColor = copy.GetPixel(i, j);
                    int r = Truncar(pixelColor.R - valor_p);
                    Color newColor = Color.FromArgb(r, pixelColor.G, pixelColor.B);
                    copy.SetPixel(i, j, newColor);
                }
            }

            return copy;

        }
        // Verde
        public Bitmap CanalVerde(int valor_p)
        {
            var copy = (Bitmap)imagen.Clone();
            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    Color pixelColor = copy.GetPixel(i, j);
                    int g = Truncar(pixelColor.G - valor_p);
                    Color newColor = Color.FromArgb(pixelColor.R, g, pixelColor.B);
                    copy.SetPixel(i, j, newColor);
                }
            }

            return copy;
        }
        // Azul
        public Bitmap CanalAzul(int valor_p)
        {
            var copy = (Bitmap)imagen.Clone();
            for (int i = 0; i < copy.Width; i++)
            {
                for (int j = 0; j < copy.Height; j++)
                {
                    Color pixelColor = copy.GetPixel(i, j);
                    int b = (int)(pixelColor.B - valor_p);
                    if (b < 0) { b = 0; }
                    Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, b);
                    copy.SetPixel(i, j, newColor);
                }
            }

            return copy;
        }

    }
}
