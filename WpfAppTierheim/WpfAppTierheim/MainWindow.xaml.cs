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

namespace WpfAppTierheim
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Verwaltung verwaltung;
        public MainWindow()
        {
            InitializeComponent();
            verwaltung = (Verwaltung)this.DataContext;
            verwaltung.onFehler += Fehlermeldung;
        }

        private void btnMitnehmen_Click(object sender, RoutedEventArgs e)
        {
            verwaltung = (Verwaltung)this.DataContext;
            verwaltung.Mitnehmen((Tier)comboBoxTiere.SelectedItem);
        }

        private void Fehlermeldung()
        {
            MessageBox.Show("Tier kann nicht mitgenommen werden!");
        }
    }
}
