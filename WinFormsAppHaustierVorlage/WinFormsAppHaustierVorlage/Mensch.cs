using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppHaustierVorlage
{
    public class Mensch
    {
        private bool laune;
        public delegate void Arbeiten();
        public Arbeiten OnArbeiten = null;
        public delegate void HomeOffice();
        public HomeOffice OnHomeOffice = null;
        public delegate void Urlaub();
        public Urlaub OnUrlaub = null;

        public Mensch()
        {
            Laune = true;
        }

        public bool Laune { get => laune; private set => laune = value; }

        public void ArbeitenGehen()
        {
            laune = false;
            if(OnArbeiten != null)
            {
                OnArbeiten();
            }
        }
        public void Fuettern()
        {
            laune = true;
        }
        public void HomeOfficeArbeiten()
        {
            laune = false;
            if(OnHomeOffice != null)
            {
                OnHomeOffice();
            }
        }

        public void UrlaubFahren()
        {
            laune = true;

            if(OnUrlaub != null)
            {
                OnUrlaub();
            }
        }

        public void TierGefüttert()
        {
            laune = true;
        }
        public void TierSaubermachen()
        {
            laune = false;
        }
    }
}
