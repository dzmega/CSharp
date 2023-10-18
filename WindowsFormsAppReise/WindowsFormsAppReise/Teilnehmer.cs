using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppReise
{
    public class Teilnehmer
    {
        private string email;
        private string nachname;
        private string vorname;
        private int anzahlTeilnehmer = 0;
        private int temp;

        public Teilnehmer()
        {

        }
        public Teilnehmer(string email, string nachname, string vorname)
        {
            this.email = email;
            this.nachname = nachname;
            this.vorname = vorname;
            anzahlTeilnehmer++;
            temp = anzahlTeilnehmer;
        }

        public string Email { get => email; set => email = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public int AnzahlTeilnehmer { get => anzahlTeilnehmer; set => anzahlTeilnehmer = value; }

        public override string ToString()
        {
            return vorname;
        }
    }
}
