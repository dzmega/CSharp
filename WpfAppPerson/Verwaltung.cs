using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPerson
{
    public class Verwaltung
    {
        private List<Person> personen;

        public Verwaltung()
        {
            personen = new List<Person>();
            personen.Add(new Person("David", "Zygmunt", 17, "Katze"));
            personen.Add(new Person("Dennis", "Reich", 18, "Katze"));
            personen.Add(new Person("Alex", "Magel", 18, "Keins"));
        }

        public List<Person> Personen { get => personen; set => personen = value; }

        public void Geburtstag(Person person)
        {
            person.Geburtstag();
        }
    }
}
