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

              


        private void Sum_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Substract(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Multiply(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Devide(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        
    }
}
