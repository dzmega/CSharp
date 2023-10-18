using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Zins
    {
        private double anfangskapital;
        private double zinsfuss;
        private int laufzeit;
        private double endkapital;

        public Zins(double anfangskapital, double zinsfuss, int laufzeit)
        {
            this.anfangskapital = anfangskapital;
            this.zinsfuss = zinsfuss;
            this.laufzeit = laufzeit;
        }

        public double Anfangskapital { get => anfangskapital; set => anfangskapital = value; }
        public double Zinsfuss { get => zinsfuss; set => zinsfuss = value; }
        public int Laufzeit { get => laufzeit; set => laufzeit = value; }
        public double Endkapital { get => endkapital; set => endkapital = value; }

        public double Berechnen()
        {
            endkapital = (anfangskapital * zinsfuss * laufzeit) / 100;
            return endkapital;
        }
    }
}
