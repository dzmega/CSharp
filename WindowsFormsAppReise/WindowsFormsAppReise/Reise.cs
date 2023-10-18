using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsAppReise
{
    public class Reise
    {
        private int anzahlTeilnehmer = 0;
        private DateTime bis;
        private int maxTeilnehmer;
        private decimal preis;
        private List<Teilnehmer> teilnehmerListe;
        private DateTime von;
        private string ziel;

        public Reise()
        {
           
        }
        public Reise(string ziel, decimal preis, DateTime von, DateTime bis, int maxTeilnehmer)
        {
            this.ziel = ziel;
            this.preis = preis;
            this.von = von;
            this.bis = bis;
            this.maxTeilnehmer = maxTeilnehmer;

            teilnehmerListe = new List<Teilnehmer>();
        }

        public int AnzahlTeilnehmer { get => anzahlTeilnehmer; set => anzahlTeilnehmer = value; }
        public DateTime Bis { get => bis; set => bis = value; }
        public int MaxTeilnehmer { get => maxTeilnehmer; set => maxTeilnehmer = value; }
        public decimal Preis { get => preis; set => preis = value; }
        public List<Teilnehmer> TeilnehmerListe { get => teilnehmerListe; set => teilnehmerListe = value; }
        public DateTime Von { get => von; set => von = value; }
        public string Ziel { get => ziel; set => ziel = value; }

        public bool TeilnehmerAufnehmen(Teilnehmer teilnehmer)
        {
            if(anzahlTeilnehmer < maxTeilnehmer)
            {
                anzahlTeilnehmer++;
                teilnehmerListe.Add(teilnehmer);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Teilnehmer>));
                TextWriter writer = new StreamWriter("Reise.xml");
                serializer.Serialize(writer, teilnehmerListe);
                writer.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TeilnehmerLöschen(Teilnehmer teilnehmer)
        {
                
                teilnehmerListe.Remove(teilnehmer);
                anzahlTeilnehmer--;
                XmlSerializer serializer = new XmlSerializer(typeof(List<Teilnehmer>));
                TextWriter writer = new StreamWriter("Reise.xml");
                serializer.Serialize(writer, teilnehmerListe);
                writer.Close();
        }

        public override string ToString()
        {
            return ziel;
        }
    }
}
