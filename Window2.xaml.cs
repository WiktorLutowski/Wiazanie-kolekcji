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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        private MainWindow mainWin = null;
        Produkt produktZListy = null;
        public Window2(MainWindow mainWin)
        {
            this.mainWin = mainWin;
            produktZListy = mainWin.lstProdukty.SelectedItem as Produkt;
            if (produktZListy == null)
                produktZListy = new Produkt("","",0,"");
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
                gridProdukt.DataContext = produktZListy; // Wybrany produkt = listy
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            mainWin.AddProdukt(produktZListy);
            Close();
        }
    }
}
