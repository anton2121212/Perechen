using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    class Class
    {
        public static double Averege(int m, int n)
        {
            int count = 0;
            int av = 0;
            for (int i = m; i <= n;i++)
            {
                av += i;
                count++;
            }
            
            return (double)av / count;
        }
    }
}
