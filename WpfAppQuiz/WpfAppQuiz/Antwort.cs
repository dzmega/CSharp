using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppQuiz
{
    public class Antwort
    {
        private string antwortmoeglichkeit;
        private bool richtig;

        public Antwort()
        {

        }

        public Antwort(string antwortmoeglichkeit, bool richtig)
        {
            this.antwortmoeglichkeit = antwortmoeglichkeit;
            this.richtig = richtig;
        }

        public string Antwortmoeglichkeit { get => antwortmoeglichkeit; set => antwortmoeglichkeit = value; }
        public bool Richtig { get => richtig; set => richtig = value; }

        public override string ToString()
        {
            return antwortmoeglichkeit;
        }
    }
}
