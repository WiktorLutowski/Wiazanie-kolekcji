﻿using System;
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
    public partial class Window1 : Window
    {

        private MainWindow mainWin = null;
        public Window1(MainWindow mainWin)
        {
            this.mainWin = mainWin;
            InitializeComponent();
            PrzygotujWiazanie();
        }
        private void PrzygotujWiazanie()
        {
            Produkt produktZListy = mainWin.lstProdukty.SelectedItem as Produkt;
            if (produktZListy != null)
                gridProdukt.DataContext = produktZListy; // Wybrany produkt = listy
        }

        private void btnPotwierdz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Czy napewno chcesz usunąć ten element?", "Potwierdzenie", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Produkt produktZListy = mainWin.lstProdukty.SelectedItem as Produkt;
                mainWin.RemoveProdukt(produktZListy);
                Close();
            }
        }
    }
}
