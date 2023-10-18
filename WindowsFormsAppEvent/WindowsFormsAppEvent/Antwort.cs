using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEvent
{
    public class Antwort
    {
        private string antwortmoeglichkeit;
        private bool richtig;

        public Antwort()
        {

        }

        public string Antwortmoeglichkeit { get => antwortmoeglichkeit; set => antwortmoeglichkeit = value; }
        public bool Richtig { get => richtig; set => richtig = value; }

        public override string ToString()
        {
            return antwortmoeglichkeit;
        }
    }
}
