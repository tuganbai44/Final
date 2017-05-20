using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        static int a = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            {
                if (textBox1.Text== "a")
                {
                    b.Text = 1;
                }
                if (textBox1.Text==)
            }
        }
    }
}
