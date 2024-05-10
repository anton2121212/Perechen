using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
{
    class Zakaz
    {
        string fan;
        int size;
        string comfort;

        public string Fan { get => fan; set => fan = value; }
        public string Comfort { get => comfort; set => comfort = value; }
        public int Size { get => size; set => size = value; }

        public Zakaz()
        {
     
        }

        public Zakaz(int size)
        {
            this.size = size;
        }
         public Zakaz(int size, string comfort)
        {
            this.size= size;
            this.comfort = comfort;
        }

        public Zakaz(string fan, int size, string comfort)
        {
            this.fan = fan;
            this.size = size;
            this.comfort = comfort;
        }

     

        public void Show()
        {
            Console.WriteLine($"Размер - {size}\nФамилия - {fan}\nКомфорт - {comfort}");
        }

    }
}
