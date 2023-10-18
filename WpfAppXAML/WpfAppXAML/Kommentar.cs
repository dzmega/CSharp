using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppXAML
{
    public class Kommentar
    {
        private string name;
        private string email;
        private string comment;

        public Kommentar()
        {
            name = "Bald sind ferien";
        }

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
