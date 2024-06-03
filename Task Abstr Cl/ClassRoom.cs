using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstr_Cl
{
    class ClassRoom
    {
       public ClassRoom() { }
        public ClassRoom(Pupil pupil) { }
        public ClassRoom(Pupil pupil, Pupil pupil1, Pupil pupil2, Pupil pupil3) { }
        public void Print(Pupil pupil)
        {
            Console.WriteLine($"Ученик {pupil.Fam}");
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            pupil.Study();
        }
    }
}
