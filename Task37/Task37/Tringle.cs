using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task37
{
   
    class Tringle
    {
     
        public static double S (double a, double b, double c)
        {

            if (a < b + c && b < a + c && c < a + b)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            }

                return 0;
        }
    }
}
