using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppZoo
{
    public class Tierverwaltung
    {
        private List<Tier> listTier;

        public Tierverwaltung()
        {
            listTier = new List<Tier>();
            listTier.Add(new Tier("Löwe","Karl",2,200));
            listTier.Add(new Tier("Puma", "Franklin", 3, 100));
            listTier.Add(new Tier("Elefant", "George", 5, 6000));
        }

        public List<Tier> ListTier { get => listTier; set => listTier = value; }
    }
}
