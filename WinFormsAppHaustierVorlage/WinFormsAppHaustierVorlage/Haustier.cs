using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustierVorlage
{
    public class Haustier
    {
        private bool laune;
        public delegate void Essen();
        public Essen OnEssen = null;
        public delegate void Waschen();
        public Waschen OnWaschen = null;

        public Haustier()
        {
            Laune = true;
        }

        public bool Laune { get => laune; private set => laune = value; }

        public void MenschArbeitet()
        {
            laune = false;
        }
        public void Fuettern()
        {
            laune = true;
            if (OnEssen != null)
            {
                OnEssen();
            }
        }
        public void Saubermachen()
        {
            laune = true;

            if(OnWaschen != null)
            {
                OnWaschen();
            }
        }

        public void MenschHomeOffice()
        {
            laune = true;
        }
        public void MenschUrlaub()
        {
            laune = false;
        }

    }
}

