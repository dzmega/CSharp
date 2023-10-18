using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Collections.ObjectModel;

namespace WpfAppLagerverwaltung
{
    public class Verwaltung
    {
        private ObservableCollection<Artikel> list;
        private DataSet dataSet;
        OleDbDataAdapter adapter;

        public Verwaltung()
        {
            list = new ObservableCollection<Artikel>();
            load();
            kundenLoad();
        }

        public ObservableCollection<Artikel> List { get => list; set => list = value; }
        public DataSet DataSet { get => dataSet; set => dataSet = value; }

        public void load()
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from tArtikel;";
            command.CommandType = CommandType.Text;

            OleDbDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Artikel a = new Artikel(Convert.ToString(checkNull(reader["ArtikelNr"])), Convert.ToInt32(checkNull(reader["ArtikelOid"])), Convert.ToInt32(checkNull(reader["Bestand"])), checkNull(reader["Bezeichnung"]).ToString(),Convert.ToInt32(checkNull(reader["Meldebestand"])),Convert.ToDecimal(checkNull(reader["VkPreis"])));
                list.Add(a);
            }

            reader.Close();
            connection.Close();
        }

        public void kundenLoad()
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            adapter = new OleDbDataAdapter("select * from tKunde", connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet,"Kunde");      
        }

        public void save()
        {
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = cmdBld.GetDeleteCommand();
            adapter.InsertCommand = cmdBld.GetInsertCommand();
            adapter.UpdateCommand = cmdBld.GetUpdateCommand();
            adapter.Update(dataSet.Tables["Kunde"]);
        }

        public void add(string anummer, int bestand, string bez, int meld, decimal preis)
        {
            int newOid = list.Count + 1;
            Artikel a = new Artikel(anummer,newOid,bestand,bez,meld,preis);
            list.Add(a);

            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "insert into tArtikel values (?,?,?,?,?,?);";
            command.Parameters.AddWithValue("@ArtikelOid", newOid);
            command.Parameters.AddWithValue("@ArtikelNr", anummer);
            command.Parameters.AddWithValue("@Bezeichnung", bez);
            command.Parameters.AddWithValue("@VkPreis", preis);
            command.Parameters.AddWithValue("@Bestand", bestand);
            command.Parameters.AddWithValue("@Meldebestand", meld);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close(); 
        }

        public void einladen(int wert, int oid)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            Console.WriteLine(wert);
            command.CommandText = "update tArtikel set Bestand = " + wert + " where ArtikelOid = " + oid + ";";
            //command.Parameters.AddWithValue("@Bestand", bestand);
            //command.Parameters.AddWithValue("@ArtikelOid", oid);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void entnehmen(int wert, int oid)
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            Console.WriteLine(wert);
            command.CommandText = "update tArtikel set Bestand = " + wert + " where ArtikelOid = " + oid + ";";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private object checkNull(object v)
        {
            if (v == DBNull.Value)
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
