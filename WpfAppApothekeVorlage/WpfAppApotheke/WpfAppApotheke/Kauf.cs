using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.ComponentModel;

namespace WpfAppApotheke
{
    public class Kauf: INotifyPropertyChanged
    {
        private ObservableCollection<Medikament> alleMedikamente;
        private ObservableCollection<Medikament> auswahlMedikamente;
        public delegate void KeinRezept();
        public KeinRezept OnKeinRezept = null;
        

        public decimal Gesamtpreis { get => gesamtpreis;
            set  { gesamtpreis = value;   }
        }

        public ObservableCollection<Medikament> AlleMedikamente { get => alleMedikamente; set => alleMedikamente = value; }
        public ObservableCollection<Medikament> AuswahlMedikamente { get => auswahlMedikamente; set => auswahlMedikamente = value; }

        private decimal gesamtpreis;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)

        {

            if (PropertyChanged != null)

                PropertyChanged(this, e);

        }

        public Kauf ()
        {
            Gesamtpreis = 0;
            AlleDeserialisieren();
            auswahlMedikamente = new ObservableCollection<Medikament> ();
        }

        public void MedikamentHinzufuegen(Medikament medikament, bool kassenrezept, bool privatrezept)
        {
            if((kassenrezept == false && privatrezept == false) && medikament.Rezeptpflichtig == true)
            {
                //delegate
                if(OnKeinRezept != null)
                {
                    OnKeinRezept();
                }
            }
            else
            {
                Gesamtpreis += medikament.ZuzahlungBerechnen(kassenrezept);
                auswahlMedikamente.Add(medikament);
                OnPropertyChanged(new PropertyChangedEventArgs("Gesamtpreis"));
            }
        }

        public decimal Kaufen()
        {
            return gesamtpreis;
        }

        public ObservableCollection<Medikament> AlleDeserialisieren()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Medikament>));
            StreamReader reader = new StreamReader("Auswahl.xml");
            alleMedikamente = (ObservableCollection<Medikament>)serializer.Deserialize(reader);
            return alleMedikamente;
        }
    }
}
