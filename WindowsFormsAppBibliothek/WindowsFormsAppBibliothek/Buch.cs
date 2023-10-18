using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBibliothek
{
    public class Buch
    {
        private bool ausgeliehen = false;
        private string autor;
        private string titel;

        public bool Ausgeliehen { get => ausgeliehen; set => ausgeliehen = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Titel { get => titel; set => titel = value; }

        public Buch()
        {

        }
        public Buch(string titel, string autor)
        {
            this.titel = titel;
            this.autor = autor;
        }

        public void Ausleihen()
        {
            ausgeliehen = true;
        }
        public void Zurückgeben()
        {
            ausgeliehen = false;
        }

        public override string ToString()
        {
            return titel + " von " + autor;
        }
    }
}
