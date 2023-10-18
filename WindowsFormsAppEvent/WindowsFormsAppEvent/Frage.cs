using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEvent
{
    public class Frage
    {
        private List<Antwort> antworten;
        private string fragestellung;
        //public delegate void showAntworten();
        //public EventHandler OnEvent = null;

        public Frage()
        {

        }
        public Frage(string fragestellung)
        {
            this.fragestellung = fragestellung;
        }

        public List<Antwort> Antworten { get => antworten; set => antworten = value; }
        public string Fragestellung { get => fragestellung; set => fragestellung = value; }

        public void Loesen()
        {
            if(antworten.Richitg == false)
            {

            }
        }

        public override string ToString()
        {
            return fragestellung;
        }
    }
}
