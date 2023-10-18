using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTierheim
{
    public class Tier
    {
        private int id;
        private string art;
        private string name;
        private int alter;
        private bool vermittelt;
        private string satz;

        public Tier()
        {

        }
        public Tier(int id, string art, string name, int alter, bool vermittelt)
        {
            this.id = id;
            this.art = art;
            this.name = name;
            this.alter = alter;
            this.vermittelt = vermittelt;
            check();
        }

        public int Id { get => id; set => id = value; }
        public string Art { get => art; set => art = value; }
        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public bool Vermittelt { get => vermittelt; set => vermittelt = value; }
        public string Satz { get => satz; set => satz = value; }

        public override string ToString()
        {
            return art + " " + name;
        }

        public void check()
        {
            if(vermittelt == true)
            {
                satz = "bereits reserviert";
            }
            else
            {
                satz = "sucht Herrchen";
            }
        }
    }
}
