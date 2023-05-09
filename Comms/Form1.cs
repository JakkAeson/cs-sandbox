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
    public partial class Form1 : Form
    {
        private readonly Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            form2.Show();
            form2.form1 = this;
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            form2.label_Message.Text = textBox_Message.Text;
        }

        private void TextBox_Sync_TextChanged(object sender, EventArgs e)
        {
            form2.textBox_Sync.Text = this.textBox_Sync.Text;
        }
    }
}
