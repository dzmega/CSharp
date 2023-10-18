using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPizza
{
    public class BestellPosition
    {
        private Int32 id;        
        private Pizza neuePizza;
        private Int32 menge;

        public BestellPosition()
        {

        }

        public BestellPosition(Pizza neuePizza, int menge)
        {
            this.neuePizza = neuePizza;
            this.menge = menge;
        }

        public BestellPosition(int id, Pizza neuePizza, int menge)
        {
            this.id = id;
            this.neuePizza = neuePizza;
            this.menge = menge;
        }

        public int Id { get => id; set => id = value; }       
        public int Menge { get => menge; set => menge = value; }
        public Pizza NeuePizza { get => neuePizza; set => neuePizza = value; }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
