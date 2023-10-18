using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WpfAppDB
{
    public class Verwaltung
    {
        ObservableCollection<Artikel> artikelliste;
        int counter = 0;
        public Verwaltung()
        {
            artikelliste = new ObservableCollection<Artikel>();
            Datenbankzugriff();
        }

        public void Datenbankzugriff()
        {
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.dbPath);
            con.Open();

            OleDbCommand cmd = con.CreateCommand();
            //cmd.CommandText = "Artikel";
            //cmd.CommandType = System.Data.CommandType.TableDirect;
            cmd.CommandText = "select * from artikel;";
            cmd.CommandType = System.Data.CommandType.Text;

            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Artikel item = new Artikel();
                item.Id = Convert.ToInt32(dr["ID"]);
                item.Bezeichnung = Convert.ToString(dr["Artikel"]);
                item.Preis = Convert.ToDecimal(dr["Preis"]);
                artikelliste.Add(item);
                counter++;
            }

            dr.Close();
            con.Close();
        }

        public void Aufnehmen(string name, decimal preis)
        {
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.dbPath);
            con.Open();
            OleDbCommand command = con.CreateCommand();
            command.CommandText = "insert into Artikel (artikel, preis) values ('" + name + "','" + preis + "');";
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
            counter++;
        }

        public void Remove(Artikel artikel)
        {
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.dbPath);
            OleDbCommand command = con.CreateCommand();
            command.CommandText = "delete from artikel where artikel = " + artikel + ";";
            command.CommandType= System.Data.CommandType.Text;
            con.Close();
        }

        public ObservableCollection<Artikel> Artikelliste { get => artikelliste; set => artikelliste = value; }
    }
}
