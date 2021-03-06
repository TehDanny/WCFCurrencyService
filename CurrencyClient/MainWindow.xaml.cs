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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CurrencyClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void ConvertFromKrToEuroBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Result: " + controller.DanishKronerToEuro(InputTbx.Text);
        }

        private void GetExchangeRateBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultLbl.Content = "Exchange rate: " + controller.GetExchangeRate(InputTbx.Text);
        }

        private void GetCurrenciesBtn_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.AutoGenerateColumns = true;
            dataGrid.ItemsSource = controller.GetCurrencies();
        }
    }
}
