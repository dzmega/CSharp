using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKurs
{
    public class Kurs
    {
        private int id;
        private string bezeichnung;
        private DateTime datum;
        private int count = 0;
        private List<Teilnehmer> teilnehmer;

        public Kurs()
        {

        }

        public Kurs(int id, string bezeichnung, DateTime datum)
        {
            this.id = id;
            this.bezeichnung = bezeichnung;
            this.datum = datum;
            teilnehmer = new List<Teilnehmer>();
        }

        public int Id { get => id; set => id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int Count { get => count; set => count = value; }
        public List<Teilnehmer> Teilnehmer { get => teilnehmer; set => teilnehmer = value; }

        public override string ToString()
        {
            return bezeichnung;
        }

        public void hinzufügen(Teilnehmer t)
        {
            teilnehmer.Add(t);
        }
    }
}
