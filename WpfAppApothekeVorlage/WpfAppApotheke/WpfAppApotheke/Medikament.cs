using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppApotheke
{
    public class Medikament
    {
        private bool rezeptpflichtig;
        private string name;
        private decimal preis;
        private decimal zuzahlung;

        public Medikament()
        { }
        public Medikament(bool rezeptpflichtig, string name, decimal preis)
        {
            this.rezeptpflichtig = rezeptpflichtig;
            this.name = name;
            this.preis = preis;
        }

        public bool Rezeptpflichtig { get => rezeptpflichtig;  set => rezeptpflichtig = value; }
        public string Name { get => name; set => name = value; }
        public decimal Preis { get => preis;  set => preis = value; }
        public decimal Zuzahlung { get => zuzahlung;  set => zuzahlung = value; }

        public decimal ZuzahlungBerechnen(bool kassenrezept)
        {
            if(kassenrezept == true)
            {
                if (5 > preis)
                {
                    zuzahlung = preis;
                }
                else
                {
                    zuzahlung = preis / 10;
                    if (preis < 5)
                    {
                        zuzahlung = 5;
                    }
                    else
                    {
                        if (zuzahlung > 10)
                        {
                            zuzahlung = 10;
                        }
                    }
                }
            }
            else
            {
                zuzahlung = preis;
            }

            return Zuzahlung;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
