using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppFaehreVorlage
{
    class Faehre
    {
        private decimal belegteLaenge;
        private decimal grundPreisLKW;
        private decimal grundPreisPKW;
        private decimal maxLaenge;
        private string name;
        private decimal preisProPerson;
        private decimal preisProTonne;
        private List<Fahrzeug> autoDeck;
        public delegate void ZuLang();
        public ZuLang OnZuLang = null;


        public Faehre()
        {
            AutoDeck = new List<Fahrzeug>();
            belegteLaenge = 0;
        }
        public Faehre(decimal decklaenge, string name):this()
        {
            Name = name;
            MaxLaenge = decklaenge;
        }
        public decimal FahrzeugAufnehmen(Fahrzeug fahrzeug)
        {
            decimal errechneterPreis = 0;
            if (maxLaenge - belegteLaenge >= (decimal) fahrzeug.Laenge)
            {
                if (fahrzeug.GetType() == typeof(LKW))
                {
                    LKW lkw = (LKW)fahrzeug;
                    errechneterPreis = grundPreisLKW + lkw.Gesamtgewicht * PreisProTonne;
                }
                else
                {
                    PKW pkw = (PKW)fahrzeug;
                    errechneterPreis = GrundPreisPKW + pkw.Personenanzahl * PreisProPerson;
                }
                AutoDeck.Add(fahrzeug);
                belegteLaenge +=(decimal) fahrzeug.Laenge;
            }
            else
            {
                if(OnZuLang != null)
                {
                    OnZuLang();
                }
            }
            return errechneterPreis;
        }

        public decimal BelegteLaenge
        {
            get
            {
                return belegteLaenge;
            }

            set
            {
                belegteLaenge = value;
            }
        }

        public decimal GrundPreisLKW
        {
            get
            {
                return grundPreisLKW;
            }

            set
            {
                grundPreisLKW = value;
            }
        }

        public decimal GrundPreisPKW
        {
            get
            {
                return grundPreisPKW;
            }

            set
            {
                grundPreisPKW = value;
            }
        }

        public decimal MaxLaenge
        {
            get
            {
                return maxLaenge;
            }

            set
            {
                maxLaenge = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal PreisProPerson
        {
            get
            {
                return preisProPerson;
            }

            set
            {
                preisProPerson = value;
            }
        }

        public decimal PreisProTonne
        {
            get
            {
                return preisProTonne;
            }

            set
            {
                preisProTonne = value;
            }
        }

        internal List<Fahrzeug> AutoDeck
        {
            get
            {
                return autoDeck;
            }

            set
            {
                autoDeck = value;
            }
        }
    }
}
