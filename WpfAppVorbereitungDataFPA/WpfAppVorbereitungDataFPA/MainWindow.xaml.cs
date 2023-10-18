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

namespace WpfAppVorbereitungDataFPA
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Verwaltung v;
        public MainWindow()
        {
            InitializeComponent();
            v = (Verwaltung)this.DataContext;
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            v.Speichern();
        }
    }
}
