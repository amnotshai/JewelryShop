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

namespace JewelryShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataStorage data = new DataStorage();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAddTransaction_Click(object sender, RoutedEventArgs e)
        {
            AddTransactionWindow AddTransaction = new AddTransactionWindow();
            AddTransaction.data = data;
            AddTransaction.Show();
        }

        private void SetPrice_Click(object sender, RoutedEventArgs e)
        {
            Price_Setter Set = new Price_Setter();
            Set.Show();
        }
    }
    public class DataStorage
    {
        public List<Person> customers = new List<Person>();

    }
    public static class DataStorages
    {
        public static List<string> buyer = new List<string>();
        public static List<decimal> price = new List<decimal>();

    }
}
