using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZoo
{
    public class Tier
    {
        private string art;
        private string name;
        private int alter;
        private double gewicht;

        public Tier(string art, string name, int alter, double gewicht)
        {
            this.art = art;
            this.name = name;
            this.alter = alter;
            this.gewicht = gewicht;
        }

        public string Art { get => art; set => art = value; }
        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public double Gewicht { get => gewicht; set => gewicht = value; }

        public void füttern()
        {
            double teil = gewicht * 0.01;
            gewicht = Math.Round((gewicht + teil), 2);
        }

        public override string ToString()
        {
            return name + " " + art + " " + alter + " " + gewicht;
        }

    }
}
