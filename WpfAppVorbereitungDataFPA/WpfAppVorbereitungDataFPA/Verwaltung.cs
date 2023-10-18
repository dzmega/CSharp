using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace WpfAppVorbereitungDataFPA
{
    public class Verwaltung
    {
        ObservableCollection<Kunde> list;
        OleDbDataAdapter adapter;
        DataSet ds;

        public Verwaltung()
        {
            list = new ObservableCollection<Kunde>();
            load();
            loadPersonal();
        }

        public ObservableCollection<Kunde> List { get => list; set => list = value; }
        public DataSet Ds { get => ds; set => ds = value; }

        private void load()
        {
            StreamReader reader = new StreamReader("Kunde.txt",Encoding.UTF8);
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            connection.Open();
            while (!reader.EndOfStream)
            {
                string z = reader.ReadLine();
                Kunde k = new Kunde(Convert.ToInt32(z.Split(';')[0]), z.Split(';')[1].ToString(), z.Split(';')[2].ToString(), z.Split(';')[3].ToString(), z.Split(';')[4].ToString(), z.Split(';')[5].ToString());
                list.Add(k);

                OleDbCommand command = connection.CreateCommand();
                command.CommandText = "insert into tKunde values(?,?,?,?,?,?)";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@KundenNr", k.Kundennummer);
                command.Parameters.AddWithValue("@KundenName", k.Kundenname);
                command.Parameters.AddWithValue("@Straße", k.Strasse);
                command.Parameters.AddWithValue("@PLZ", k.Plz);
                command.Parameters.AddWithValue("@Ort", k.Ort);
                command.Parameters.AddWithValue("@Telefon", k.Telefon);
                command.ExecuteNonQuery();
            }
            connection.Close();
            reader.Close();
        }

        private void loadPersonal()
        {
            OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.dbPath);
            adapter = new OleDbDataAdapter("select * from tPersonal;",connection);
            ds = new DataSet();
            adapter.Fill(ds, "Personal");
        }

        public void Speichern()
        {
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.Update(ds.Tables["Personal"]);
        }
    }
}
