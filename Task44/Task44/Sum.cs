using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task44
{
    class Sum
    {
        public static int Sum2(int n,int m)
        {
            int sum = 0;
            for (int i = m; i<=n;i++  )
            {
                sum += i;
            }
            return sum;
        }
    }
}
