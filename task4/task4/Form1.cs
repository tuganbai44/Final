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
        static int x, y;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             x = e.Location.X;
             y = e.Location.Y;
            draw();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x+=30;
        }

        public void draw()
        {
             g.DrawEllipse(new Pen(Color.Black), x - 15, y - 15, 30, 30);
        }
    }
}



