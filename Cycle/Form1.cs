using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle
{
    public partial class Form1 : Form
    {
        double hue = 0;
        double sat = 1;
        double val = 1;
        double cosine = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (hue >= 360) hue = 0;
            if (cosine >= 360) cosine = 0;

            sat = (Math.Cos(cosine) + 1) / 2;
            val = sat;
            */

            sat = (double)this.DesktopLocation.X / Screen.FromControl(this).WorkingArea.Width;
            val = 1 - (double)this.DesktopLocation.Y / Screen.FromControl(this).WorkingArea.Height;

            this.BackColor = Color.FromArgb(GetRGBValue(hue, sat, val, 5),
                                            GetRGBValue(hue, sat, val, 3),
                                            GetRGBValue(hue, sat, val, 1));

            hue += 0.5;
            //cosine += 0.01;
        }

        private int GetRGBValue(double hue, double saturation, double value, int RGB)
        {
            // 5 for R, 3 for G, 1 for B
            double k = (RGB + (hue / 60)) % 6;
            double result = value - (value * saturation * Math.Max(0, Math.Min(k, Math.Min(4 - k, 1))));
            double v = result * 255;
            return (int)((v < 0) ? 0 : (v > 255) ? 255 : v);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
