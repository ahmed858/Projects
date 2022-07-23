using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Line : Form
    {
        public Line()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X1 = int.Parse(textBox1.Text);
            int Y1 = int.Parse(textBox2.Text);
            int X2 = int.Parse(textBox3.Text);
            int Y2 = int.Parse(textBox4.Text);
            int dx = X2 - X1;
            int dy = Y2 - Y1;
            int p0 = (2 * dy) - dx;
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i <= dx - 1; i++)
            {
                b.SetPixel(X1, Y1, Color.Black);
                if (p0 < 0)
                {
                    p0 = p0 + (2 * dy);
                    X1++;
                }
                else
                {
                    p0 = p0 + (2 * dy) - (2 * dx);
                    X1++;
                    Y1++;
                }
            }
            pictureBox1.Image = b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
