using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfAppPizza
{
    public class Bestellung
    {
        private DateTime datum;
        private Decimal bestellwert;
        private Kunde kunde;
        private ObservableCollection<BestellPosition> lstpositionen = new ObservableCollection<BestellPosition>();

        public DateTime Datum { get => datum; set => datum = value; }
        public decimal Bestellwert { get => bestellwert; set => bestellwert = value; }
        public Kunde Kunde { get => kunde; set => kunde = value; }
        public ObservableCollection<BestellPosition> Lstpositionen { get => lstpositionen; set => lstpositionen = value; }

        public Bestellung()
        {
            datum = DateTime.Today;
        }        

        public Bestellung(DateTime datum, Kunde kunde)
        {
            this.datum = datum;
            this.kunde = kunde;
        }

        public void AddBestellposition(BestellPosition bestellpos)
        {
            
           
        }

        public override string ToString()
        {
            return datum.ToString();
        }
    }
}
