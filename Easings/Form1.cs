using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easings
{
    public partial class Form1 : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        int x1, x2, y1, y2, w1, w2, h1, h2;
        bool moving;
        bool direction;
        int duration;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            textBox_x1.Text = this.Location.X.ToString();
            textBox_x2.Text = this.Location.X.ToString();
            textBox_y1.Text = this.Location.Y.ToString();
            textBox_y2.Text = this.Location.Y.ToString();

            textBox_w1.Text = this.Size.Width.ToString();
            textBox_w2.Text = this.Size.Width.ToString();
            textBox_h1.Text = this.Size.Height.ToString();
            textBox_h2.Text = this.Size.Height.ToString();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            double progress;
            string easingType;
            if (moving)
            {
                progress = stopwatch.Elapsed.TotalMilliseconds / duration;
                easingType = comboBox_Type.SelectedItem.ToString();
                if (progress < 1)
                {
                    if (direction)
                    {
                        this.Location = new Point((int)Ease(x1, x2, progress, easingType), (int)Ease(y1, y2, progress, easingType));
                        this.Size = new Size((int)Ease(w1, w2, progress, easingType), (int)Ease(h1, h2, progress, easingType));
                    }
                    else
                    {
                        this.Location = new Point((int)Ease(x2, x1, progress, easingType), (int)Ease(y2, y1, progress, easingType));
                        this.Size = new Size((int)Ease(w2, w1, progress, easingType), (int)Ease(h2, h1, progress, easingType));
                    }
                }
                else
                {
                    if (direction)
                    {
                        this.Location = new Point(x2, y2);
                        this.Size = new Size(w2, h2);
                    }
                    else
                    {
                        this.Location = new Point(x1, y1);
                        this.Size = new Size(w1, h1);
                    }

                    moving = false;
                    stopwatch.Reset();
                }
                this.Invalidate();
            }
        }

        private void Button_1to2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Duration.Text, out duration) && comboBox_Type.SelectedItem != null)
            {
                x1 = int.Parse(textBox_x1.Text);
                x2 = int.Parse(textBox_x2.Text);
                y1 = int.Parse(textBox_y1.Text);
                y2 = int.Parse(textBox_y2.Text);

                w1 = int.Parse(textBox_w1.Text);
                w2 = int.Parse(textBox_w2.Text);
                h1 = int.Parse(textBox_h1.Text);
                h2 = int.Parse(textBox_h2.Text);

                direction = true;
                moving = true;
                stopwatch.Restart();
                this.Invalidate();
            }
        }

        private void Button_2to1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Duration.Text, out duration) && comboBox_Type.SelectedItem != null)
            {
                x1 = int.Parse(textBox_x1.Text);
                x2 = int.Parse(textBox_x2.Text);
                y1 = int.Parse(textBox_y1.Text);
                y2 = int.Parse(textBox_y2.Text);

                w1 = int.Parse(textBox_w1.Text);
                w2 = int.Parse(textBox_w2.Text);
                h1 = int.Parse(textBox_h1.Text);
                h2 = int.Parse(textBox_h2.Text);

                direction = false;
                moving = true;
                stopwatch.Restart();
                this.Invalidate();
            }

        }
        private void Button_SetLoc1_Click(object sender, EventArgs e)
        {
            textBox_x1.Text = this.Location.X.ToString();
            textBox_y1.Text = this.Location.Y.ToString();
        }

        private void Button_SetLoc2_Click(object sender, EventArgs e)
        {
            textBox_x2.Text = this.Location.X.ToString();
            textBox_y2.Text = this.Location.Y.ToString();
        }

        private void Button_SetSize1_Click(object sender, EventArgs e)
        {
            textBox_w1.Text = this.Size.Width.ToString();
            textBox_h1.Text = this.Size.Height.ToString();
        }

        private void Button_SetSize2_Click(object sender, EventArgs e)
        {
            textBox_w2.Text = this.Size.Width.ToString();
            textBox_h2.Text = this.Size.Height.ToString();
        }

        private double Ease(double start, double end, double progress, string type)
        {
            double result;
            switch (type)
            {
                case "Linear":
                    result = progress;
                    break;
                case "Sine In":
                    result = EaseInSin(progress);
                    break;
                case "Sine Out":
                    result = EaseOutSin(progress);
                    break;
                case "Sine InOut":
                    result = EaseInOutSin(progress);
                    break;
                case "Quadratic In":
                    result = EaseInQuad(progress);
                    break;
                case "Quadratic Out":
                    result = EaseOutQuad(progress);
                    break;
                case "Quadratic InOut":
                    result = EaseInOutQuad(progress);
                    break;
                case "Cubic In":
                    result = EaseInCubic(progress);
                    break;
                case "Cubic Out":
                    result = EaseOutCubic(progress);
                    break;
                case "Cubic InOut":
                    result = EaseInOutCubic(progress);
                    break;
                case "Quartic In":
                    result = EaseInQuart(progress);
                    break;
                case "Quartic Out":
                    result = EaseOutQuart(progress);
                    break;
                case "Quartic InOut":
                    result = EaseInOutQuart(progress);
                    break;
                case "Quintic In":
                    result = EaseInQuint(progress);
                    break;
                case "Quintic Out":
                    result = EaseOutQuint(progress);
                    break;
                case "Quintic InOut":
                    result = EaseInOutQuint(progress);
                    break;
                case "Exponential In":
                    result = EaseInExp(progress);
                    break;
                case "Exponential Out":
                    result = EaseOutExp(progress);
                    break;
                case "Exponential InOut":
                    result = EaseInOutExp(progress);
                    break;
                case "Circular In":
                    result = EaseInCirc(progress);
                    break;
                case "Circular Out":
                    result = EaseOutCirc(progress);
                    break;
                case "Circular InOut":
                    result = EaseInOutCirc(progress);
                    break;
                case "Overshoot In":
                    result = EaseInBack(progress);
                    break;
                case "Overshoot Out":
                    result = EaseOutBack(progress);
                    break;
                case "Overshoot InOut":
                    result = EaseInOutBack(progress);
                    break;
                case "Elastic In":
                    result = EaseInElastic(progress);
                    break;
                case "Elastic Out":
                    result = EaseOutElastic(progress);
                    break;
                case "Elastic InOut":
                    result = EaseInOutElastic(progress);
                    break;
                case "Bounce In":
                    result = EaseInBounce(progress);
                    break;
                case "Bounce Out":
                    result = EaseOutBounce(progress);
                    break;
                case "Bounce InOut":
                    result = EaseInOutBounce(progress);
                    break;
                default:
                    result = progress;
                    break;
            }
            return start + ((end - start) * result);
        }

        #region Easing Functions
        private static double EaseInSin(double progress)
        {
            return 1 - Math.Cos(progress * Math.PI / 2);
        }

        private static double EaseOutSin(double progress)
        {
            return Math.Sin(progress * Math.PI / 2);
        }

        private static double EaseInOutSin(double progress)
        {
            return -(Math.Cos(Math.PI * progress) - 1) / 2;
        }


        private static double EaseInQuad(double progress)
        {
            return progress * progress;
        }

        private static double EaseOutQuad(double progress)
        {
            return 1 - (1 - progress) * (1 - progress);
        }

        private static double EaseInOutQuad(double progress)
        {
            return progress < 0.5 ? 2 * progress * progress
                                                        : 1 - (Math.Pow((-2 * progress) + 2, 2) / 2);
        }


        private static double EaseInCubic(double progress)
        {
            return progress * progress * progress;
        }

        private static double EaseOutCubic(double progress)
        {
            return 1 - Math.Pow(1 - progress, 3);
        }

        private static double EaseInOutCubic(double progress)
        {
            return progress < 0.5 ? 4 * progress * progress * progress
                                                        : 1 - (Math.Pow((-2 * progress) + 2, 3) / 2);
        }


        private static double EaseInQuart(double progress)
        {
            return Math.Pow(progress, 4);
        }

        private static double EaseOutQuart(double progress)
        {
            return 1 - Math.Pow(1 - progress, 4);
        }

        private static double EaseInOutQuart(double progress)
        {
            return progress < 0.5 ? 8 * Math.Pow(progress, 4)
                                                        : 1 - (Math.Pow((-2 * progress) + 2, 4) / 2);
        }


        private static double EaseInQuint(double progress)
        {
            return Math.Pow(progress, 5);
        }

        private static double EaseInOutQuint(double progress)
        {
            return progress < 0.5 ? 16 * Math.Pow(progress, 5)
                                                        : 1 - (Math.Pow((-2 * progress) + 2, 5) / 2);
        }

        private static double EaseOutQuint(double progress)
        {
            return 1 - Math.Pow(1 - progress, 5);
        }


        private static double EaseInExp(double progress)
        {
            return progress == 0 ? 0 : Math.Pow(2, (10 * progress) - 10);
        }

        private static double EaseOutExp(double progress)
        {
            return progress == 1 ? 1 : 1 - Math.Pow(2, -10 * progress);
        }

        private static double EaseInOutExp(double progress)
        {
            if (progress == 0)
            {
                return 0;
            }
            else if (progress == 1)
            {
                return 1;
            }
            else if (progress < 0.5)
            {
                return Math.Pow(2, (20 * progress) - 10) / 2;
            }
            else
            {
                return (2 - Math.Pow(2, (-20 * progress) + 10)) / 2;
            }

        }


        private static double EaseInCirc(double progress)
        {
            return 1 - Math.Sqrt(1 - Math.Pow(progress, 2));
        }

        private static double EaseOutCirc(double progress)
        {
            return Math.Sqrt(1 - Math.Pow(progress - 1, 2));
        }

        private static double EaseInOutCirc(double progress)
        {
            return progress < 0.5 ? (1 - Math.Sqrt(1 - Math.Pow(2 * progress, 2))) / 2
                                  : (Math.Sqrt(1 - Math.Pow((-2 * progress) + 2, 2)) + 1) / 2;
        }


        private static double EaseInBack(double progress)
        {
            double c1 = 1.70158; // 10% overshoot
            double c3 = 1 + c1;
            return (c3 * Math.Pow(progress, 3)) - (c1 * progress * progress);
        }

        private static double EaseOutBack(double progress)
        {
            double c1 = 1.70158; // 10% overshoot
            double c3 = 1 + c1;
            return 1 + (c3 * Math.Pow(progress - 1, 3)) + (c1 * Math.Pow(progress - 1, 2));
        }

        private static double EaseInOutBack(double progress)
        {
            double c1 = 1.70158; // 10% overshoot
            double c2 = c1 * 1.525;
            return progress < 0.5 ? Math.Pow(2 * progress, 2) * (((c2 + 1) * 2 * progress) - c2) / 2
                                    : ((Math.Pow((2 * progress) - 2, 2) * (((c2 + 1) * ((progress * 2) - 2)) + c2)) + 2) / 2;
        }


        private static double EaseInElastic(double progress)
        {
            double c4 = 2 * Math.PI / 3;
            if (progress == 0)
            {
                return 0;
            }
            else if (progress == 1)
            {
                return 1;
            }
            else
            {
                return -Math.Pow(2, (10 * progress) - 10) * Math.Sin(((progress * 10) - 10.75) * c4);
            }
        }

        private static double EaseOutElastic(double progress)
        {
            double c4 = 2 * Math.PI / 3;
            if (progress == 0)
            {
                return 0;
            }
            else if (progress == 1)
            {
                return 1;
            }
            else
            {
                return (Math.Pow(2, -10 * progress) * Math.Sin(((progress * 10) - 0.75) * c4)) + 1;
            }
        }

        private static double EaseInOutElastic(double progress)
        {
            double c5 = (2 * Math.PI) / 4.5;
            if (progress == 0)
            {
                return 1;
            }
            else if (progress == 1)
            {
                return 1;
            }
            else if (progress < 0.5)
            {
                return -(Math.Pow(2, (20 * progress) - 10) * Math.Sin(((20 * progress) - 11.125) * c5)) / 2;
            }
            else
            {
                return (Math.Pow(2, (-20 * progress) + 10) * Math.Sin(((20 * progress) - 11.125) * c5) / 2) + 1;
            }
        }


        private double EaseOutBounce(double progress)
        {
            double n1 = 7.5625;
            double d1 = 2.75;

            if (progress < 1 / d1)
            {
                return n1 * progress * progress;
            }
            else if (progress < 2 / d1)
            {
                return (n1 * (progress -= 1.5 / d1) * progress) + 0.75;
            }
            else if (progress < 2.5 / d1)
            {
                return (n1 * (progress -= 2.25 / d1) * progress) + 0.9375;
            }
            else
            {
                return n1 * (progress -= 2.625 / d1) * progress + 0.984375;
            }
        }

        private double EaseInBounce(double progress)
        {
            return 1 - EaseOutBounce(1 - progress);
        }

        private double EaseInOutBounce(double progress)
        {
            return progress < 0.5 ? (1 - EaseOutBounce(1 - (2 * progress))) / 2
                                  : (1 + EaseOutBounce((2 * progress) - 1)) / 2;
        }
        #endregion
    }
}
