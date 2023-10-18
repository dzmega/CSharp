using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHaustiermanager
{
    public class Hund:Tier
    {
        private int hundesteuernr;
        public Hund(string name, double gewicht, int impfungen, int hundesteuernummer):base()
        {
            Name = name;
            Gewicht = gewicht;
            Impfungen = impfungen;
            this.hundesteuernr = hundesteuernummer;
        }

        public int Hundesteuernr { get => hundesteuernr; set => hundesteuernr = value; }
    }
}
