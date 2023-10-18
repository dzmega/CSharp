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

namespace WpfAppKurs
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Verwaltung verwaltung;
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            verwaltung = (Verwaltung)this.DataContext;
        }

        private void Anzeigen_Click(object sender, RoutedEventArgs e)
        {
            if(i == 0)
            {
                verwaltung.DatenLesen();
                i++;
            }
        }

        private void Kursxml_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.KurseSerialisieren();
        }

        private void Teilnehmerexml_Click(object sender, RoutedEventArgs e)
        {
            verwaltung.TeilnehmerSerialisieren();
        }
    }
}
