using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            label_Message.Text = form1.textBox_Message.Text;
        }

        private void TextBox_Sync_TextChanged(object sender, EventArgs e)
        {
            form1.textBox_Sync.Text = this.textBox_Sync.Text;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }
    }
}
