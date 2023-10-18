using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Xml.Serialization;

namespace WpfAppKurs
{
    public class Verwaltung
    {
        List<Teilnehmer> alleTeilnehmer;
        List<Kurs> kurse;

        public Verwaltung()
        {
            alleTeilnehmer = new List<Teilnehmer>();
            kurse = new List<Kurs>();
        }

        public List<Kurs> Kurse { get => kurse; set => kurse = value; }
        public List<Teilnehmer> AlleTeilnehmer { get => alleTeilnehmer; set => alleTeilnehmer = value; }

        public void DatenLesen()
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "Select * from tKurs;";

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Kurs kurs = new Kurs(Convert.ToInt32(checkNull(reader["ID"])), Convert.ToString(checkNull(reader["Bezeichnung"])), Convert.ToDateTime(checkNull(reader["Datum"])));
                kurse.Add(kurs);
            }
            reader.Close();
            connection.Close();

            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.dbPath);
            con.Open();
            OleDbCommand com = con.CreateCommand();
            com.CommandText = "select * from tTeilnehmer;";
            com.CommandType = System.Data.CommandType.Text;

            OleDbDataReader r = com.ExecuteReader();
            while(r.Read())
            {
                Teilnehmer teilnehmer = new Teilnehmer(Convert.ToInt32(checkNull(r["ID"])), Convert.ToString(checkNull(r["Vorname"])), Convert.ToString(checkNull(r["Nachname"])), Convert.ToString(checkNull(r["Email"])));
                alleTeilnehmer.Add(teilnehmer);
            }
            r.Close();
            con.Close();

            OleDbConnection connection2 = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection2.Open();
            OleDbCommand command2 = connection2.CreateCommand();
            command2.CommandText = "select * from tKurszuTeilnehmer;";
            command2.CommandType = System.Data.CommandType.Text;

            OleDbDataReader reader2 = command2.ExecuteReader();
            while(reader2.Read())
            {  
                foreach (Teilnehmer t in AlleTeilnehmer)
                {
                    if (t.Id == Convert.ToInt32(checkNull(reader2["TeilnehmerID"])))
                    {
                        Kurse[(Convert.ToInt32(checkNull(reader2["KursID"]))-1)].hinzufügen(t);
                    }
                }
            }
            reader2.Close();
            connection2.Close();
        }

        public void KurseSerialisieren()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kurs>));
            TextWriter writer = new StreamWriter("Kurse.xml");
            serializer.Serialize(writer, kurse);
            writer.Close();
        }

        public void TeilnehmerSerialisieren()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kurs>));
            TextWriter writer = new StreamWriter("Teilnehmer.xml");
            serializer.Serialize(writer, alleTeilnehmer);
            writer.Close();
        }

        private object checkNull(object v)
        {
            if(v == DBNull.Value)
            {
                return null;
            }
            else
            {
                return v;
            }
        }
    }
}
