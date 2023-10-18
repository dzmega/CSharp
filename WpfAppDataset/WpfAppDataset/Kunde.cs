using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataset
{
    public class Kunde
    {
        private string name;
        private string vorname;

        public Kunde()
        {

        }

        public Kunde(string vorname, string name)
        {
            this.name = name;
            this.vorname = vorname;
        }

        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }

        public override string ToString()
        {
            return vorname + " " + name;
        }
    }
}
