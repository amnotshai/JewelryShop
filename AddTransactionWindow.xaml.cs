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
using System.Windows.Shapes;

namespace JewelryShop
{
    /// <summary>
    /// Interaction logic for AddTransactionWindow.xaml
    /// </summary>
    public partial class AddTransactionWindow : Window
    {
        public MainWindow main = new MainWindow();
        public string name = "";
        public decimal price;
        public DataStorage data;
        public Person customer;
        public decimal weight;
        public AddTransactionWindow()
        {
            InitializeComponent();
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            cmbCustomers.Items.Clear();
            foreach (Person customer in data.customers)
            {
                cmbCustomers.Items.Add(customer.GetFullName());
            }


            //switch(cmbQuality.Text)
            //{
            //    case "10k":
            //        price = DataStorages.price[0];
            //        return;
            //    case "18k":
            //        price = DataStorages.price[1];
            //        return;
            //    case "21k":
            //        price = DataStorages.price[2];
            //        return;

            //}




        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {

            main.Show();
            this.Hide();
        }


        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {

            AddCustomerWindow newCustomer = new AddCustomerWindow();
            newCustomer.data = data;
            newCustomer.Show();
            DataStorages.buyer.Add(cmbCustomers.Text);
        }

        private void BtnCalculatePrice_Click(object sender, RoutedEventArgs e)
        {
            weight = Convert.ToDecimal(txtWeight.Text) - Convert.ToDecimal(txtCrystalWeight);
            switch (cmbQuality.Text)
            {
                case "10K":
                    txtbPrice.Text = Convert.ToString(weight * DataStorages.price[0]);
                    return;
                case "18K":
                    txtbPrice.Text = Convert.ToString(weight * DataStorages.price[1]);
                    return;
                case "21K":
                    txtbPrice.Text = Convert.ToString(weight * DataStorages.price[2]);
                    return;
            }
        }
    }
}
