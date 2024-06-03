using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstr_Cl
{
    abstract class Pupil
    {
        string fam;
        public string Fam { get; set; }
        public Pupil() { }
        public Pupil(string fam)
        {
            Fam = fam;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
