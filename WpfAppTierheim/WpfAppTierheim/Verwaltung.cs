using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.ComponentModel;

namespace WpfAppTierheim
{
    public class Verwaltung : INotifyPropertyChanged
    {
        private List<Tier> tiere;
        public delegate void Fehler();
        public Fehler onFehler = null;
        OleDbConnection connection;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public Verwaltung()
        {
            tiere = new List<Tier>();
            connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            Einlesen();
        }

        public List<Tier> Tiere { get => tiere; set => tiere = value; }

        public void Mitnehmen(Tier tier)
        {
            connection.Open();

            OleDbCommand command = connection.CreateCommand();
            if(tier.Vermittelt == false)
            {
                command.CommandText = "update tiere set vermittelt = 1 where id =" + tier.Id + ";";
                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();
                Console.WriteLine("Herzlichen Glückwunsch!");
                tier.Vermittelt = true;
                tier.Satz = "reserviert";
                
            }
            else
            {
                Console.WriteLine("Nicht möglich!");
                if(onFehler != null)
                {
                    onFehler();
                }
            }

            OnPropertyChanged(new PropertyChangedEventArgs("Tiere"));

            connection.Close();
        }

        public void Einlesen()
        {
            
            connection.Open();

            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from tiere;";
            command.CommandType = System.Data.CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Tier tier = new Tier(Convert.ToInt32(reader["ID"]),Convert.ToString(reader["art"]),Convert.ToString(reader["tiername"]),Convert.ToInt32(reader["tieralter"]),Convert.ToBoolean(reader["vermittelt"]));
                tiere.Add(tier);
            }

            reader.Close();
            connection.Close();
        }
    }
}
