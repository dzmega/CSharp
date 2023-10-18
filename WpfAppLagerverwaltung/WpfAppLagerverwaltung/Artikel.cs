using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLagerverwaltung
{
    public class Artikel
    {
        private string artikelnummer;
        private int artikelOid;
        private int bestand;
        private string bezeichnung;
        private int meldebestand;
        private decimal vkPreis;
        public delegate void Fehler();
        public Fehler onFehler = null;

        public Artikel()
        {

        }

        public Artikel(string artikelnummer, int artikelOid, int bestand, string bezeichnung, int meldebestand, decimal vkPreis)
        {
            this.artikelnummer = artikelnummer;
            this.artikelOid = artikelOid;
            this.bestand = bestand;
            this.bezeichnung = bezeichnung;
            this.meldebestand = meldebestand;
            this.vkPreis = vkPreis;
        }

        public string Artikelnummer { get => artikelnummer; set => artikelnummer = value; }
        public int ArtikelOid { get => artikelOid; set => artikelOid = value; }
        public int Bestand { get => bestand; set => bestand = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public int Meldebestand { get => meldebestand; set => meldebestand = value; }
        public decimal VkPreis { get => vkPreis; set => vkPreis = value; }

        public override string ToString()
        {
            return artikelnummer + " " + bezeichnung;
        }

        public void ArtikelEinladen(int menge)
        {
            bestand += menge;
        }

        public void ArtikelEntnehmen(int menge)
        {
            if((bestand-menge) > meldebestand)
            {
                bestand -= menge;
            }
            else
            {
                if(onFehler != null)
                {
                    onFehler();
                }    
            }
        }
    }
}
