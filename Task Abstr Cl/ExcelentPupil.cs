using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstr_Cl
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string fam) : base(fam) { }

        public override void Study()
        {
            Console.WriteLine($"{Fam} учится отлично");
        }

        public override void Read()
        {
            Console.WriteLine($"{Fam} читает очень хорпошо");
        }

        public override void Write()
        {
            Console.WriteLine($"{Fam} пишет без ошибок");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Fam} отдыхает игря в шахматы");
        }
    }
}
