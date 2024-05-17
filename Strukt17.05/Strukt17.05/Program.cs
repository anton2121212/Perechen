using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukt17._05
{
    class Program
    {

        
            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "изменено";
            }

            static void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "изменено";
            }

            public static void Main(string[] args)
            {
                MyClass myClass = new MyClass();
                myClass.change = "не изменено";

                MyStruct myStruct = new MyStruct();
                myStruct.change = "не изменено";

                Console.WriteLine("Значение поля экземпляра MyClass до вызова метода: " + myClass.change);
                Console.WriteLine("Значение поля экземпляра MyStruct до вызова метода: " + myStruct.change);

                ClassTaker(myClass);
                StruktTaker(myStruct);

                Console.WriteLine("Значение поля экземпляра MyClass после вызова метода: " + myClass.change);
                Console.WriteLine("Значение поля экземпляра MyStruct после вызова метода: " + myStruct.change);
            Console.ReadKey();
            }
        
    }
}
