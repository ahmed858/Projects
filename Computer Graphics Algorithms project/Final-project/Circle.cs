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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int XCenter = pictureBox1.Width / 2;    //int.Parse(textBox1.Text);
            int YCenter = pictureBox1.Height / 2;//int.Parse(textBox2.Text);
            int R = int.Parse(textBox3.Text);
            int X = R, Y = 0;
            int pk = 100 - R;
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            while (X >= Y)
            {
                b.SetPixel(XCenter + X, YCenter + Y, Color.Red);

                b.SetPixel(XCenter + Y, YCenter + X, Color.Red);
                b.SetPixel(XCenter - X, YCenter + Y, Color.Red);
                b.SetPixel(XCenter - Y, YCenter + X, Color.Red);
                b.SetPixel(XCenter - X, YCenter - Y, Color.Red);
                b.SetPixel(XCenter - Y, YCenter - X, Color.Red);
                b.SetPixel(XCenter + X, YCenter - Y, Color.Red);
                b.SetPixel(XCenter + Y, YCenter - X, Color.Red);

                if (pk <= 0)
                {
                    Y++;
                    pk = pk + (2 * Y) + 1;
                }
                else
                {
                    X--;
                    Y++;
                    pk = pk + (2 * Y) - (2 * X) + 1;
                }
            }
            pictureBox1.Image = b;
        }
    }
}
