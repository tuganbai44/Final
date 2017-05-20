using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace task4
{
    public partial class Form1 : Form
    {

        Graphics g;
        SolidBrush l;
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
            l = new SolidBrush(Color.Black);
            Graphics g;
            Bitmap bmp = new Bitmap;
            pictureBox1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
        }

        public void draw()
        {
            g.FillEllipse(l, 15, 15, 32, 32);

        }
    }
}
