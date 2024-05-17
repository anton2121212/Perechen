using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukt2
{
   public struct Notebook
    {
        public string model;
        public string manufacturer;
        public double price;

        // Конструктор для инициализации полей
        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        // Метод для вывода содержимого полей на экран
        public void DisplayInfo()
        {
            Console.WriteLine("Модель: " + model);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + price);
        }
    }
}
