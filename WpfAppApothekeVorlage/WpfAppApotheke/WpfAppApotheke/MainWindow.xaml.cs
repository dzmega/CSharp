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

namespace WpfAppApotheke
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }



        private void buttonHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            Kauf kauf = (Kauf)this.DataContext;
            kauf.OnKeinRezept += fehlermeldung;
            kauf.MedikamentHinzufuegen((Medikament)comboBoxAlleMedikamente.SelectedItem, (bool)radioKassenrezept.IsChecked, (bool)radioPrivatrezept.IsChecked);
            kauf.OnKeinRezept -= fehlermeldung;
        }

        private void buttonKaufen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void fehlermeldung()
        {
            MessageBox.Show("Medikament benötigt Rezept!");
        }
    }
}
