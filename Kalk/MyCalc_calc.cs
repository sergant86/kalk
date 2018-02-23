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
    public partial class MyCalc_calc
    {
        public static int Sum(int _a, int _b)
        {
           return _a + _b;
            
        }
        public static int Substract(int _a = 0, int _b = 0)
        {
            return _a - _b;

        }
        public static int Multiply(int _a = 0, int _b = 0)
        {
            return _a * _b;

        }
        public static int Devide(int _a = 0, int _b = 0)
        {
            return _a / _b;

        }
    }

    
}
