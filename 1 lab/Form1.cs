using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lab
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = RailFence.Encrypt(textBox1.Text, 4);
            //label1.Text = RailFence.Decrypt(RailFence.Encrypt(textBox1.Text, 4), 4);
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Текущее значение ключа: {0}", trackBar1.Value);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
