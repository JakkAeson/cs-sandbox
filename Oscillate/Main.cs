using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscillate
{
    public partial class Main : Form
    {
        int direction = 1;
        double speedX = 0.0001;
        double speedY = 0.001;
        double sineX = 0;
        double sineY = 0;

        public Main()
        {
            InitializeComponent();
            this.Size = new Size(250, 100);
            label1.Location = new Point(0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if (label1.Location.X < 0 || (label1.Location.X + label1.Size.Width - 10) > this.Size.Width)
            {
                direction *= -1;
            }

            label1.Location = new Point
            {
                X = (int)((this.Size.Width - label1.Size.Width - 11) * (1 + Math.Sin(sineX * 360)) / 2),
                Y = (int)((this.Size.Height - label1.Size.Height * 4) * (1 + Math.Sin(sineY * 360)) / 2)
            };

            sineY += speedY;
            if (sineY >= 1) sineY = 0;

            sineX += speedX;
            if (sineX >= 1) sineX = 0;
        }
    }
}
