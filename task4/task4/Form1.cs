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
            l = new SolidBrush(Color.Beige);
            Graphics g;
            Bitmap bmp = new Bitmap;
            pictureBox1 = new bmp
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            g.FillEllipse(l, 15, 15, 32, 32);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
        }
    }
}
