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
               

        public static MyCalc_calc MyCalc = new MyCalc_calc();


        int _text1, _text2;
        string _text3;

        private  void Sum_Click(object sender, EventArgs e)
            {

                try
                {
                    _text1 = int.Parse(textBox1.Text);

                    _text2 = int.Parse(textBox2.Text);

                    label1.Text = Convert.ToString(MyCalc_calc.Sum(_text1 + _text2));
                }
                catch (FormatException)
                {
                    _text3 = ("не тот формат ввода");
                    textBox3.Text = _text3;
                }
               
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
