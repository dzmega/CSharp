using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Auto
    {
        private string kennzeichen;
        private int km;

        public Auto(string kennzeichen)
        {
            this.kennzeichen = kennzeichen;
            this.km = 0;
        }

        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public int Km { get => km; set => km = value; }

        public void Fahren(int km)
        {
            this.km += km;
        }

        public override string ToString()
        {
            return kennzeichen;
        }
    }
}
