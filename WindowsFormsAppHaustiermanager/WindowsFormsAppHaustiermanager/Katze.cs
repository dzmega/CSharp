using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHaustiermanager
{
    public class Katze:Tier
    {
        public Katze(string name, double gewicht, int impfungen)
        {
            Name = name;
            Gewicht = gewicht;
            Impfungen = impfungen;
        }
    }
}
