using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class VMZins: INotifyPropertyChanged
    {
        private Zins zins;
        public VMZins(double anfangskapital, double zinsfuss, int laufzeit)
        {
            zins = new Zins(anfangskapital,zinsfuss,laufzeit);
        }
        public double Anfanskapital
        {
            get => zins.Anfangskapital;
            set { zins.Anfangskapital = value; OnPropertyChanged(new PropertyChangedEventArgs("Anfangskapital")); }
        }
        public double Zinsfuss
        {
            get => zins.Zinsfuss;
            set { zins.Zinsfuss = value; OnPropertyChanged(new PropertyChangedEventArgs("Zinsfuss")); }
        }
        public int Laufzeit
        {
            get => zins.Laufzeit;
            set { zins.Laufzeit = value; OnPropertyChanged(new PropertyChangedEventArgs("Laufzeit")); }
        }
        public double Endkapital
        {
            get => zins.Endkapital;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }
    }
}
