using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalk
{
    class Exceptions
    {
        
       

        public Сalculator MyCalcExceptions1 = new Сalculator();

        public static void Sum1(int a = 0, int b = 0)
        {
            

            try
            {
                
                if (a < 0)
                    throw new ArgumentException(Convert.ToString(MyCalc_calc.Sum(TextBox3 = "Параметр должен быть больше 0")));
                if (b < 0)
                    throw new ArgumentException(Convert.ToString("Параметр должен быть больше 0"));
            }

            catch (Exception ex)
            {
                throw ex;
            }

          

        }
    }
}
