using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsAppEvent
{
    public class FrageVerwaltung
    {
        private List<Frage> fragen;

   
        public FrageVerwaltung()
        {
            fragen = new List<Frage>();
        }

        public List<Frage> Fragen { get => fragen; set => fragen = value; }

        public void Lesen()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Frage>));
            TextReader reader = new StreamReader("Fragen.xml");
            fragen = (List<Frage>)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
