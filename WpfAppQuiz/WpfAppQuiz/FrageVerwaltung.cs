using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;

namespace WpfAppQuiz
{
    public class FrageVerwaltung : INotifyPropertyChanged
    {
        private List<Frage> fragen;

        public FrageVerwaltung()
        {
            fragen = new List<Frage>();
            //Lesen();
        }

        public List<Frage> Fragen { get => fragen; set { fragen = value; OnPropertyChanged(new ProgressChangedEventArgs(""))} }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(ProgressChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public void Lesen()
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<Frage>));
            TextReader reader = new StreamReader("Fragen.xml");
            fragen = (List<Frage>)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
