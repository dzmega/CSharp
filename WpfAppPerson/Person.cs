﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPerson
{
    public class Person:INotifyPropertyChanged
    {
        private string vorname;
        private string nachname;
        private int alter;
        private string haustier;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        public Person()
        {

        }
        public Person(string vorname, string nachname, int alter, string haustier)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.haustier = haustier;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public int Alter { get => alter; set => alter = value; }
        public string Haustier { get => haustier; set => haustier = value; }

        public override string ToString()
        {
            return vorname + " " + nachname;
        }

        public void Geburtstag()
        {
            alter++;
            OnPropertyChanged(new PropertyChangedEventArgs("Alter"));
        }
    }
}
