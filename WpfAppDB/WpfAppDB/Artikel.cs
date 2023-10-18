using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDB
{
    public class Artikel
    {
        private int id;
        private string bezeichnung;
        private decimal preis;

        public Artikel()
        {

        }

        public Artikel(string bezeichnung, decimal preis)
        {
            this.bezeichnung = bezeichnung;
            this.Preis = preis;
        }

        public int Id { get => id; set => id = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public decimal Preis { get => preis; set => preis = value; }

        public override string ToString()
        {
            return bezeichnung;
        }
    }
}
