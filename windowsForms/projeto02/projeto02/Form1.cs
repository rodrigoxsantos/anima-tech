﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1, numero2, res;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;

            float n1, n2, r;

            n1 = float.Parse(numero1);
            n2 = float.Parse(numero2);

            r = n1 + n2;

            res = string.Format("{0:N2}", r);


            label4.Text = label4.Text + res + " | ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numero1, numero2, res;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;

            float n1, n2, r;

            n1 = float.Parse(numero1);
            n2 = float.Parse(numero2);

            r = n1 - n2;

            res = string.Format("{0:N2}", r);


            label4.Text = label4.Text + res + " | ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numero1, numero2, res;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;

            float n1, n2, r;

            n1 = float.Parse(numero1);
            n2 = float.Parse(numero2);

            r = n1 * n2;

            res = string.Format("{0:N2}", r);


            label4.Text = label4.Text + res + " | ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string numero1, numero2, res;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;

            float n1, n2, r;

            n1 = float.Parse(numero1);
            n2 = float.Parse(numero2);

            r = n1 / n2;

            res = string.Format("{0:N2}", r);


            label4.Text = label4.Text + res + " | ";
        }
    }
}
