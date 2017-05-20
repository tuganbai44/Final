using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {

        static int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.BackColor == Color.Red)
            { button1.BackColor = Color.Yellow;
                a = 1;

            }
            else if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.Blue;
                a = 2;
            }
            else if (button1.BackColor == Color.Blue)
            {
                button1.BackColor = Color.Red;
                a = 0;
            }
        }
    }
}
