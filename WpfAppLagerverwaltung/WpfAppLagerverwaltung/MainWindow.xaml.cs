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

namespace WpfAppLagerverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Verwaltung verwaltung;
        Artikel artikel;
        int wert;

        public MainWindow()
        {
            InitializeComponent();
            verwaltung = (Verwaltung)this.DataContext;
            artikel = new Artikel();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.save();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            verwaltung.add(txtArtikelnummer.Text.ToString(), Convert.ToInt32(txtBestand.Text.ToString()), txtBezeichnung.Text.ToString(), Convert.ToInt32(txtMeldebestand.Text.ToString()), Convert.ToDecimal(txtVKPreis.Text.ToString()));
        }

        private void btnAuslagern_Click(object sender, RoutedEventArgs e)
        {
            artikel = (Artikel)ArtikelBox.SelectedItem;
            wert = artikel.Bestand - Convert.ToInt32(txtAnzahl.Text);
            artikel.onFehler += fehlermeldung;
            artikel.ArtikelEntnehmen(Convert.ToInt32(txtAnzahl.Text));
            verwaltung.entnehmen(wert, ((Artikel)ArtikelBox.SelectedItem).ArtikelOid);
        }

        private void btnEinlagern_Click(object sender, RoutedEventArgs e)
        {
            artikel = (Artikel)ArtikelBox.SelectedItem;
            wert = artikel.Bestand + Convert.ToInt32(txtAnzahl.Text);
            artikel.ArtikelEinladen(Convert.ToInt32(txtAnzahl.Text));
            verwaltung.einladen(wert, ((Artikel)ArtikelBox.SelectedItem).ArtikelOid);
        }

        private void fehlermeldung()
        {
            MessageBox.Show("Bestellen!");
        }
    }
}
