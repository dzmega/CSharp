using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;

namespace WpfAppPizza
{
    public class Pizzeria
    {
        private Bestellung bestellung;
        ObservableCollection<Pizza> pizzen;
        ObservableCollection<Kunde> kunden;

        public Pizzeria()
        {
            pizzen = new ObservableCollection<Pizza>();
            kunden = new ObservableCollection<Kunde>();
            EinlesenPizza();
            EinlesenKunden();
        }

        public Bestellung Bestellung { get => bestellung; set => bestellung = value; }
        public ObservableCollection<Pizza> Pizzen { get => pizzen; set => pizzen = value; }
        public ObservableCollection<Kunde> Kunden { get => kunden; set => kunden = value; }

        public void EinlesenPizza()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Pizza>));
            TextReader reader = new StreamReader("Pizza.xml");
            pizzen = (ObservableCollection<Pizza>)serializer.Deserialize(reader);
            reader.Close();

        }

        public void EinlesenKunden()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Kunde>));
            TextReader reader = new StreamReader("Kunde.xml");
            kunden = (ObservableCollection<Kunde>)serializer.Deserialize(reader);
            reader.Close();
        }

        public void BestellungAufnehmen(Kunde kunde)
        {
            Bestellung bestellung;
            DateTime datum = DateTime.Today;
            bestellung = new Bestellung(datum, kunde);
        }
    }
}
