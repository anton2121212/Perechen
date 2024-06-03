using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstr_Cl
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil("Мустяца");
            GoodPupil goodPupil = new GoodPupil("Салтыков");
            BadPupil badPupil = new BadPupil("Мутаф");
            ClassRoom classRoom = new ClassRoom(excelentPupil, goodPupil, badPupil,badPupil);
            classRoom.Print(excelentPupil);
            classRoom.Print(goodPupil);
            classRoom.Print(badPupil);
            Console.ReadKey();

        }
    }
}
