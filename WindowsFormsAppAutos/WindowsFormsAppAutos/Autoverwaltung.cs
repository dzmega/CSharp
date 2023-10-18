using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAutos
{
    public class Autoverwaltung
    {
        private List<Auto> listAuto;
        
        public Autoverwaltung()
        {
            listAuto = new List<Auto>();
            listAuto.Add(new Auto("SW RR 996", 20, 70000, 6));
            listAuto.Add(new Auto("WÜ DN 1307", 26, 58000, 8));
        }
        public void AutoErzeugen(String kennzeichen,double aktuelleFuellung, int km, double verbrauch)
        {
            listAuto.Add(new Auto(kennzeichen,aktuelleFuellung,km,verbrauch));
        }

        public List<Auto> ListAuto { get => listAuto; set => listAuto = value; }

    }
}
