using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_41
{
    class Triangle<T>
    {
        private T a;
        private T b;
        private T c;

        public T A
        {
            set { value = a; }
            get { return a; }
        }
        public T B
        {
            set { value = b; }
            get { return b; }
        }
        public T C
        {
            set { value = c; }
            get { return c; }
        }
        public Triangle()
        {

        }
        public Triangle (T a, T b, T c)
        {
            if ((dynamic)a < ((dynamic)b + (dynamic)c) && ((dynamic)b < ((dynamic)a + (dynamic)c) && (dynamic)c < ((dynamic)a) + (dynamic)b))
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                A = (dynamic)0;
                B = (dynamic)0;
                C = (dynamic)0;
            }
        }

        public void Print ()
        {
            Console.WriteLine($" A={A}, B={B}, C={C}");
        }
        public double Area()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            if (a1 == 0 && b1 == 0 && c1 == 0)
            {
                return 0;
            }
            else
            {
                double p = (double)(a1 + b1 + c1) / 2;
                return Math.Sqrt((dynamic)p * ((dynamic) p - a1) * ((dynamic) p - b1) * ((dynamic) p - c1));
            }
        }
    }
}
