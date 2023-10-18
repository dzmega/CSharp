using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class VMPerson: INotifyPropertyChanged
    {
        private Person person;
        public VMPerson(string vorname, string nachname, int alter)
        {
            person = new Person(vorname, nachname, alter);
        }
        public string Vorname
        {
            get => person.Vorname;
            set { person.Vorname = value; OnPropertyChanged(new PropertyChangedEventArgs("Vorname")); } 
        }

        public string Nachname
        {
            get => person.Nachname;
            set { person.Nachname = value; OnPropertyChanged(new PropertyChangedEventArgs("Nachname")); }
        }

        public void Geburtstag()
        {
            person.Geburtstag();
            OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
        }

        public int Alter
        {
            get => person.Alter;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, args);
            }
        }

        public override string ToString()
        {
            return person.Vorname;
        }
    }
}
