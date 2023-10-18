using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppQuiz
{
    public class Frage
    {
        private List<Antwort> antworten;
        private string fragestellung;

        public Frage()
        {
           antworten = new List<Antwort>();
        }

        public Frage(List<Antwort> antworten, string fragestellung)
        {
            antworten = new List<Antwort>();
            this.fragestellung = fragestellung;
        }

        public List<Antwort> Antworten { get => antworten; set => antworten = value; }
        public string Fragestellung { get => fragestellung; set => fragestellung = value; }

        public override string ToString()
        {
            return fragestellung;
        }
    }
}
