using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class VMAuto: INotifyPropertyChanged
    {
        private Auto auto;

        public VMAuto(string kennzeichen)
        {
            auto = new Auto(kennzeichen);
        }

        public string Kennzeichen { get => auto.Kennzeichen; set => auto.Kennzeichen = value; }
        public int Km { get => auto.Km;}

        public event PropertyChangedEventHandler PropertyChanged;


        public void Fahren(int km)
        {
            auto.Fahren(km);
            OnPropertyChanged(new PropertyChangedEventArgs("Km"));
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, eventArgs);
            }
        }
    }
}
