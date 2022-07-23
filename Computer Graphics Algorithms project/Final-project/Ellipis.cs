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
    public partial class Ellipis : Form
    {
        public Ellipis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text); //pictureBox1.Width / 2;
            int b = int.Parse(textBox2.Text); //pictureBox1.Height / 2;
            int XCenter = pictureBox1.Width / 2;    //int.Parse(textBox1.Text);
            int YCenter = pictureBox1.Height / 2;//int.Parse(textBox2.Text);
            int x = 0, y = b;
            int p = (b * b) - (a * a * b) + (1 / 4) * (a * a);
            Bitmap f = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            while ((2 * b * b * x) < (2 * a * a * y))
            {
                f.SetPixel(XCenter + x, YCenter + y, Color.Black);

                f.SetPixel(XCenter - x, YCenter + y, Color.Black);

                f.SetPixel(XCenter - x, YCenter - y, Color.Black);
                f.SetPixel(XCenter + x, YCenter - y, Color.Black);

                if (p < 0)
                {
                    x++;

                    p = p + (2 * b * b * x) + (b * b);
                }
                else
                {
                    x++;
                    y--;
                    p = p + (2 * b * b * x) + (b * b) - (2 * a * a * y);

                }
            }
            int p1 = (b * b * (x + 1 / 2) * (x + 1 / 2)) + (a * a * (y - 1) * (y - 1) - (a * a * b * b));
            while (y > 0)
            {
                f.SetPixel(XCenter + x, YCenter + y, Color.Black);

                f.SetPixel(XCenter - x, YCenter + y, Color.Black);
                f.SetPixel(XCenter - x, YCenter - y, Color.Black);

                f.SetPixel(XCenter + x, YCenter - y, Color.Black);
                if (p1 < 0)
                {
                    x++;
                    y--;
                    p1 = p1 + (2 * b * b * x) - (2 * a * a * y) + (a * a);
                }
                else
                {
                    y--;
                    p1 = p1 - (2 * a * a * y) + (a * a);
                }

            }

            pictureBox1.Image = f;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
