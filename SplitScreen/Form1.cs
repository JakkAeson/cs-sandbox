using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitScreen
{
    public partial class Form1 : Form
    {
        private static readonly int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        private static readonly int screenHeight = Screen.PrimaryScreen.Bounds.Height;

        //static Bitmap screenLeft = new Bitmap(screenWidth / 2, screenHeight);
        //static Bitmap screenRight = new Bitmap(screenLeft);
        private static readonly Bitmap screen = new Bitmap(screenWidth, screenHeight);

        Stopwatch stopwatch = new Stopwatch();

        public Form1()
        {
            this.Visible = false;
            InitializeComponent();
            Thread.Sleep(1500);

            Graphics graphics;
            /*
            graphics = Graphics.FromImage(screenLeft);
            graphics.CopyFromScreen(Point.Empty, Point.Empty, new Size(screenWidth / 2, screenHeight));

            graphics = Graphics.FromImage(screenRight);
            graphics.CopyFromScreen(new Point(screenWidth / 2, 0), Point.Empty, new Size(screenWidth / 2, screenHeight));
            */
            graphics = Graphics.FromImage(screen);
            graphics.CopyFromScreen(Point.Empty, Point.Empty, new Size(screenWidth, screenHeight));
            graphics.Dispose();

            stopwatch.Start();
            //for (int i = 0; i < (screenWidth); i++)
            //{
                Parallel.For(0, screenWidth, (i) =>
                {
                    for (int j = 0; j < screenHeight; j++)
                    {
                        //screenLeft.SetPixel(i, j, PixelHueShift(screenLeft.GetPixel(i, j), 270));
                        //screenRight.SetPixel(i, j, PixelHueShift(screenRight.GetPixel(i, j), 90));
                        lock (this)
                        {
                            screen.SetPixel(i, j, PixelHueShift(screen.GetPixel(i, j), (int)((1 + Math.Sin(0.005 * i) / 2) * 360)));
                        }
                    }
                });
            //}

            this.Visible = true;
            Debug.WriteLine(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(screenLeft, Point.Empty);
            //e.Graphics.DrawImage(screenRight, new Point(screenWidth / 2, 0));
            e.Graphics.DrawImage(screen, Point.Empty);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Color PixelHueShift(Color pixel, int degrees)
        {
            double r, g, b;
            double v, c;
            double hue, sat;

            r = pixel.R / 255.0;
            g = pixel.G / 255.0;
            b = pixel.B / 255.0;

            v = Math.Max(r, Math.Max(g, b));
            c = v - Math.Min(r, Math.Min(g, b));

            if (c != 0)
            {
                if (v == r)
                {
                    hue = 60.0 * (0 + ((g - b) / c));
                }
                else if (v == g)
                {
                    hue = 60.0 * (2 + ((b - r) / c));
                }
                else
                {
                    hue = 60.0 * (4 + ((r - g) / c));
                }
            }
            else
            {
                hue = 0;
            }

            if (v != 0)
            {
                sat = c / v;
            }
            else
            {
                sat = 0;
            }

            hue += degrees;
            if (hue >= 360)
            {
                hue -= 360;
            }

            return Color.FromArgb(GetRGBValue(hue, sat, v, 5),
                                  GetRGBValue(hue, sat, v, 3),
                                  GetRGBValue(hue, sat, v, 1));
        }

        private int GetRGBValue(double hue, double saturation, double value, int RGB)
        {
            // RGB = 5 for R, 3 for G, 1 for B
            double k = (RGB + (hue / 60)) % 6;
            double result = value - (value * saturation * Math.Max(0, Math.Min(k, Math.Min(4 - k, 1))));
            double v = result * 255;
            return (int)((v < 0) ? 0 : (v > 255) ? 255 : v);
        }
    }
}
