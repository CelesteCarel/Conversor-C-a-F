﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_C_a_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(gradoscels.Text);
            float Fahrenheit = (Celsius * 9 / 5) + 32;
            gradosfahr.Text = Fahrenheit.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float Fahrenheit = float.Parse(gradosfahr.Text);
            float Celsius = (Fahrenheit - 32) * 5 / 9;
            gradoscels.Text = Celsius.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gradoscels.Text = " ";
            gradosfahr.Text = " ";
        }
    }
}
