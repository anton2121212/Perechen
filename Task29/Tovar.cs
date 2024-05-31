using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task29
{
    class Tovar
    {
        string name;
        double price;
        int kvo;

        public string Name { get; set; }
        public double Price { get { return Price; } set { if (value < 0 || value > 10) Console.WriteLine("Кол-во должно быть от 0 до 20"); else value = Price;  } }
        public int Kvo { get { return Kvo; } set { if (value < 1 || value > 10) Console.WriteLine("Кол-во должно быть от 1 до 10"); else value = Kvo; } }

        public Tovar() { }
        public Tovar (string name, double price, int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }
        public static Tovar InPut()
        {
            Console.WriteLine("Введите название товара:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите цену товара:");
            double Price = double.Parse( Console.ReadLine());
            Console.WriteLine("Введите количество товара:");
            int Kvo = int.Parse( Console.ReadLine());

            Console.WriteLine($" Название{Name}, Цена{Price},  Количество{Kvo}");
            
            return new Tovar(Name, Price, Kvo);
        }
        public double Sum()
        {
            return Price * Kvo;
        }

    }
}
