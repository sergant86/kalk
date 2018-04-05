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


       
            private void Sum_Click(object sender, EventArgs e) 
                {
            
                label1.Text = Convert.ToString(MyCalc_calc.Sum(_text1 + _text2));

                }

        private void Substract_Click(object sender, EventArgs e)
            {
            label1.Text = Convert.ToString(MyCalc_calc.Substract(_text1 + _text2));
            }

        private void Multiply_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(MyCalc_calc.Multiply(_text1 + _text2));
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(MyCalc_calc.Devide(_text1 + _text2));
        }

        public int _text1, _text2;
        public string _text3;
        public void _MyException()
        {
            try
            {
                _text1 = int.Parse(textBox1.Text);

                _text2 = int.Parse(textBox2.Text);

            }
            catch (FormatException)
            {
                _text3 = ("Не тот формат ввода");
                label1.Text = "Введите цифру";
                textBox3.Text = _text3;
            }
            catch (DivideByZeroException)
            {
                _text3 = ("Попытка деления на ноль");
                label1.Text = "Введите не ноль";
                textBox3.Text = _text3;
            }
            catch (IndexOutOfRangeException)
            {
                _text3 = ("Укажите хотя бы один аргумент");
                textBox3.Text = _text3;
            }
            catch (OverflowException)
            {
                _text3 = ("Вы ввели число которое выходит за диапазон чисел типа");
                label1.Text = "Введите от  -2 147 483 648 до  +2 147 483 648";
                textBox3.Text = _text3;
            }

        }



    }

}
