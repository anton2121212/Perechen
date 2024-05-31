using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task28
{
    class Tour
    {
        string country;
        int day;
        double price;

        public string Country { get; set; }
        public int Day { get; set; }
        public double Price { get; set; }
        

        public Tour() { }
        public Tour (string country, int day, double price)
        {
            Country = country;
            Day = day;
            Price = price;
        }

        public void Tour1 ()
        {
            Console.WriteLine("Минское море, бесплатно");
        }

        public void Tour2(string Country)
        {
           
            Console.WriteLine($"Страна: {Country}, 1 день,  стоимость=50 руб, всего {1 * 50}р");
        }
        public void Tour3 (string Country,int Day )
        {
           
            Console.WriteLine($"Страна: {Country}, Количество дней{Day}, стоимость 50 руб, всего {Day * 50}р");
        }


    }
}
