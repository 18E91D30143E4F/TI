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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch (cbMetod.SelectedIndex)
            {
                case 0:
                    tbResult.Text = RailFence.Encrypt(tbText.Text, Int16.Parse(tbKey.Text));
                    break;
                case 1:
                    tbResult.Text = Columns.Encrypt(tbText.Text, tbKey.Text);
                    break;
                case 2:
                    tbResult.Text = RotateGrid.Encrypt(tbText.Text, tbKey.Text);
                    break;
                case 3:
                    tbResult.Text = CaesarCipher.Encrypt(tbText.Text, Int32.Parse(tbKey.Text));
                    break;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            switch (cbMetod.SelectedIndex)
            {
                case 0:
                    tbResult.Text = RailFence.Decrypt(tbResult.Text, Int16.Parse(tbKey.Text));
                    break;
                case 1:
                    tbResult.Text = Columns.Decrypt(tbResult.Text, tbKey.Text);
                    break;
                case 2:
                    tbResult.Text = RotateGrid.Decrypt(tbResult.Text, tbKey.Text);
                    break;
                case 3:
                    tbResult.Text = CaesarCipher.Decrypt(tbResult.Text, Int32.Parse(tbKey.Text));
                    break;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
