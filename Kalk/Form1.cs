using System;
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

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public MyCalc_calc MyCalc = new MyCalc_calc();
        public int Su = MyCalc_calc.Sum();
        public int Sub = MyCalc_calc.Substract();
        public int Mul = MyCalc_calc.Multiply();
        public int Dev = MyCalc_calc.Devide();


        public void Sum_Click(object sender, EventArgs e)
            {
            
            label1.Text = Convert.ToString(Su(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            
        }

        private void Substract_Click(object sender, EventArgs e)
            {
                label1.Text = Convert.ToString(Substract(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }

      
        private void Multiply_Click(object sender, EventArgs e)
            {
                label1.Text = Convert.ToString(Multiply(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }

   
        private void Devide_Click(object sender, EventArgs e)
            {
                label1.Text = Convert.ToString(Devide(Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)));
            }

        
    }
}
