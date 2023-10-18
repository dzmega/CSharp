using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCollection
{
    public class Schüler
    {
        private string name;
        private DateTime geburtstag;
        private string wohnort;

        public Schüler()
        {

        }
        public Schüler(string name, DateTime geburtstag, string wohnort)
        {
            this.name = name;
            this.geburtstag = geburtstag;
            this.wohnort = wohnort;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Geburtstag { get => geburtstag; set => geburtstag = value; }
        public string Wohnort { get => wohnort; set => wohnort = value; }

        public override string ToString()
        {
            return name + " " + geburtstag;
        }
    }
}
