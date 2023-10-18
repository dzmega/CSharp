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

namespace WpfAppDB
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

        private void btnAufnehmen_Click(object sender, RoutedEventArgs e)
        {
            Verwaltung v = (Verwaltung)this.DataContext;
            v.Aufnehmen(txtName.Text, Convert.ToDecimal(txtPreis.Text));
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Verwaltung v = (Verwaltung)this.DataContext;
            v.Remove();
        }
    }
}
