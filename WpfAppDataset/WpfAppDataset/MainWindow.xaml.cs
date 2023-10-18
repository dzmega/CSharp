using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;

namespace WpfAppDataset
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection con;
        DataSet ds;
        OleDbDataAdapter adapter;
        DataTableReader dr;
        List<Kunde> kundenliste;
        OleDbDataAdapter adapterWagen;
        OleDbDataAdapter adapterMiete;

        public MainWindow()
        {
            InitializeComponent();
            con = new OleDbConnection(Properties.Settings.Default.dbPath);
            kundenliste = new List<Kunde>();
            ds = new DataSet();
        }

        private void Adapter_Click(object sender, RoutedEventArgs e)
        {
            adapter = new OleDbDataAdapter("select vorname, name from tKunde;",con);
        }

        private void DatasetFüllen_Click(object sender, RoutedEventArgs e)
        {
            adapter.Fill(ds, "Kunde");
        }

        private void DatasetAuslesen_Click(object sender, RoutedEventArgs e)
        {
            dr = ds.Tables["Kunde"].CreateDataReader();
            while (dr.Read())
            {
               kundenliste.Add(new Kunde(dr[0].ToString(), dr[1].ToString()));
            }
            dr.Close();
            List.ItemsSource = kundenliste;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adapterWagen = new OleDbDataAdapter("select * from tWagen;", con); 
            adapterWagen.Fill(ds, "Wagen");
            dgDaten.ItemsSource = ds.Tables["Wagen"].AsDataView();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder(adapterWagen);
            adapterWagen.DeleteCommand = cmdBld.GetDeleteCommand();
            adapterWagen.InsertCommand = cmdBld.GetInsertCommand();
            adapterWagen.UpdateCommand = cmdBld.GetUpdateCommand();
            adapterWagen.Update(ds.Tables["Wagen"]);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            adapterMiete = new OleDbDataAdapter("select * from tMietvertrag;", con);
            adapterMiete.Fill(ds, "Mietvertrag");
            dgMiete.ItemsSource = ds.Tables["Mietvertrag"].AsDataView();

            /*OleDbCommandBuilder cmdBld = new OleDbCommandBuilder();
            adapterMiete.DeleteCommand = cmdBld.GetDeleteCommand();
            adapterMiete.InsertCommand = cmdBld.GetInsertCommand();
            adapterMiete.UpdateCommand = cmdBld.GetUpdateCommand();
            adapterMiete.Update(ds.Tables["Mietvertrag"]);*/
        }
    }
}
