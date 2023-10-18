using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    public class Faehre
    {
        private decimal belegteLänge;
        private decimal grundPreisLKW = 100;
        private decimal grundPreisPKW = 20;
        private decimal maxLänge;
        private string name;
        private decimal preisProPerson = 5;
        private decimal preisProTonne = 10;

        public Faehre()
        {

        }
        public Faehre(decimal decklaenge, string name)
        {
            this.MaxLänge = decklaenge;
            this.Name = name;
        }
        /*public Faehre(decimal belegteLänge, decimal grundPreisLKW, decimal grundPreisPKW, decimal maxLänge, string name, decimal preisProPerson, decimal preisProTonne)
        {
            this.belegteLänge = belegteLänge;
            this.grundPreisLKW = grundPreisLKW;
            this.grundPreisPKW = grundPreisPKW;
            this.maxLänge = maxLänge;
            this.name = name; 
            this.preisProPerson = preisProPerson;
            this.preisProTonne = preisProTonne;
        }*/

        public decimal BelegteLänge { get => belegteLänge; set => belegteLänge = value; }
        public decimal GrundPreisLKW { get => grundPreisLKW; set => grundPreisLKW = value; }
        public decimal GrundPreisPKW { get => grundPreisPKW; set => grundPreisPKW = value; }
        public decimal MaxLänge { get => maxLänge; set => maxLänge = value; }
        public string Name { get => name; set => name = value; }
        public decimal PreisProPerson { get => preisProPerson; set => preisProPerson = value; }
        public decimal PreisProTonne { get => preisProTonne; set => preisProTonne = value; }

        public decimal FahrzeugAufnehmen(Fahrzeug fahrzeug)
        {
            decimal preis = 0;

            if(fahrzeug.GetType() == typeof(LKW))
            {
                
            }
            else
            {

            }
            return preis;
        }         
    }
}
