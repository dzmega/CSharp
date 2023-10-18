using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKurs
{
    public class Teilnehmer
    {
        private int id;
        private string vorname;
        private string nachname;
        private string email;

        public Teilnehmer()
        {

        }

        public Teilnehmer(int id, string vorname, string nachname, string email)
        {
            this.id = id;
            this.vorname = vorname;
            this.nachname = nachname;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }
    }
}
