﻿using System;
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


        static int l;
        static int a = (l / 2) % 0;
        static int c;

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
                if (b.Text== "0")
                {
                    b.Text = "1";
                }
                else if (b.Text == "1")
                {
                    b.Text = "2";
                }

                else if (b.Text == "2")
                {
                    b.Text = "3";
                }

                else if (b.Text == "3")
                {
                    b.Text = "4";
                }

                else if (b.Text == "4")
                {
                    b.Text = "5";
                }

                else if (b.Text == "5")
                {
                    b.Text = "6";
                }
            }
            if(b.Text=="a")
            {
                c++;
            }
        }
    }
}
