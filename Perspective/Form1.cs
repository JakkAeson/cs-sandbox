using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depth
{
    public partial class Form1 : Form
    {
        private List<Box> Boxes = new List<Box>();
        Timer Timer = new Timer();
        double XVal = 0;
        double YVal = 0;
        int Freq = 60;
        double speedMult = 1;

        class Box
        {
            public Color Color;
            public Size Size;
            public double X;
            public double Y;
            public double Z;
        }

        public Form1()
        {
            InitializeComponent();
            CreateBoxes(100, 10, 2);
            this.DoubleBuffered = true;

            Timer.Tick += Timer_Tick;
            Timer.Interval = 1000 / Freq;
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            XVal += 1.0 / (Freq * speedMult) % 360;
            YVal += 1.0 / (Freq * speedMult) % 360;

            CalculateProperties(XVal, YVal);
            DrawBoxes();
        }

        void DrawBoxes()
        {
            Bitmap bitmap = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.Clear(BackColor);
                foreach (var box in Boxes)
                {
                    graphics.FillEllipse(
                        new SolidBrush(box.Color),
                        (float)((1 + box.X) / 2 * this.ClientRectangle.Width),
                        (float)((1 + box.Y) / 2 * this.ClientRectangle.Height),
                        box.Size.Width,
                        box.Size.Height);
                }
            }

            if (this.BackgroundImage != null)
            {
                this.BackgroundImage.Dispose();
            }

            this.BackgroundImage = bitmap;
        }

        void CalculateProperties(double x, double y)
        {
            foreach (var box in Boxes)
            {
                double cosX = Math.Cos(x * 360);
                double sinY = Math.Sin(y * 360);

                box.X = cosX / -box.Z;
                box.Y = sinY / -box.Z;

                x += 1.0 / (Freq * speedMult);
                y += 1.0 / (Freq * speedMult);
            }
        }

        void CreateBoxes(int count, int depth, int startDepth)
        {
            double depthStep = (double)depth / count;
            double z = -startDepth - depth;
            
            double colourStep = 255.0 / count;
            double red = 0.0;

            double sizeStep = depthStep;
            double size = 0;

            for (int i = 0; i < count; i++)
            {
                Boxes.Add(new Box
                {
                    Color = Color.FromArgb((int)red, 0, 0),
                    Size = new Size((int)size, (int)size),
                    X = 0,
                    Y = 0,
                    Z = z
                });

                red += colourStep;
                z += depthStep;
                size += sizeStep;
            }
        }
    }
}
