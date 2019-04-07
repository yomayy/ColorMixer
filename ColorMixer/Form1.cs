using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {

        int r;
        int g;
        int b;

        public Form1()
        {
            InitializeComponent();
            r = 150;
            g = 150;
            b = 150;
            Indicate();
        }

        private void Indicate()
        {
            r = RedBar.Value;
            g = GreenBar.Value;
            b = BlueBar.Value;

            RedLabel.Text = r.ToString();
            GreenLable.Text = g.ToString();
            BlueLabel.Text = b.ToString();

            label1.Text = String.Format("RGB code: ({0},{1},{2})", r, g, b);

            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private void RedBar_ValueChanged(object sender, EventArgs e)
        {
            Indicate();
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            Indicate();
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            Indicate();
        }
    }
}
