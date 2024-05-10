using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task47
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool stop = true;
            for (; stop;)
            {
                
               Console.WriteLine();
                       string fam = Console.ReadLine();
                        Console.WriteLine();
                       int size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                       string comfort = Console.ReadLine();

                Zakaz zakaz = new Zakaz(fam,size,comfort);
                zakaz.Show();
                string comand = Console.ReadLine();
                switch (comand) 
                {
                 
                    case "Q": stop = false; break;
                }
               
            }

            
        }
        
    }
}
