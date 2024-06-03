using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstr_Cl
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string fam) : base(fam) { }

        public override void Study()
        {
            Console.WriteLine($"{Fam} учится хорошо");
        }

        public override void Read()
        {
            Console.WriteLine($"{Fam} читает достаточно быстро");
        }

        public override void Write()
        {
            Console.WriteLine($"{Fam} пишет с небольшими ошибками");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Fam} отдыхает смотря телевизор");
        }
    }
}
