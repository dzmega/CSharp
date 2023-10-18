using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppHaustiermanager
{
    public class Tier
    {
        private string name;
        private double gewicht;
        private int impfungen;

        public Tier()
        {

        }
        public Tier(string name, double gewicht, int impfungen)
        {
            this.name = name;
            this.gewicht = gewicht;
            this.impfungen = impfungen;
        }

        public string Name { get => name; set => name = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }
        public int Impfungen { get => impfungen; set => impfungen = value; }

        public override string ToString()
        {
            return name + " " + gewicht + " "+ impfungen;
        }

        public virtual void Füttern()
        {
            gewicht = Math.Round((gewicht * 1.02),2);
        }
        public virtual void Impfen()
        {
            impfungen++;
        }
    }
}
