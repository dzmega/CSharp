using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEimer
{
    public class Eimer
    {
        private int aktuelleFuellmenge;
        private int maxFuellmenge;
        public delegate void FillError();
        public FillError onFillError = null;

        public Eimer()
        {

        }
        public Eimer(int maxMenge)
        {
            this.maxFuellmenge = maxMenge;
        }

        public int AktuelleFuellmenge { get => aktuelleFuellmenge; set => aktuelleFuellmenge = value; }
        public int MaxFuellmenge { get => maxFuellmenge; set => maxFuellmenge = value; }

        public void Einfuellen(int menge)
        {
            if (this.AktuelleFuellmenge + menge > this.MaxFuellmenge)
            {
                if(onFillError != null)
                {
                    onFillError();
                }
            }
            else this.AktuelleFuellmenge += menge;
        }
    }
}
