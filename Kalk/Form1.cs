﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalk
{

    public partial class Сalculator : Form
    {

        public Сalculator()
        {
            InitializeComponent();
        }


        public MyCalc_calc MyCalc = new MyCalc_calc();
        

        
        public  void Sum_Click(object sender, EventArgs e)
            {
            label1.Text = Convert.ToString(MyCalc_calc.Sum(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }
        private void Substract_Click(object sender, EventArgs e)
            {

            label1.Text = Convert.ToString(MyCalc_calc.Substract(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }
        private void Multiply_Click(object sender, EventArgs e)
            {
                label1.Text = Convert.ToString(MyCalc_calc.Multiply(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }
        private void Devide_Click(object sender, EventArgs e)
            {
                label1.Text = Convert.ToString(MyCalc_calc.Devide(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }
    }
}
