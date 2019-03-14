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
            for(int x=0;x<DataStorages.buyer.Count;x++)
            {
                cmbCustomers.Items.Add(DataStorages.buyer[x]);
            }
            
            foreach (Person customer in data.customers)
            {
                cmbCustomers.Items.Add(customer.GetFullName());
            }

        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {

            main.Show();
            DataStorages.jewelry.Add(cmbProduct.Text);
            DataStorages.quality.Add(cmbQuality.Text);
            DataStorages.weight.Add(weight);
            DataStorages.details.Add(txtDetails.Text);
            DataStorages.price.Add(Convert.ToDecimal(txtbPrice.Text));
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
           
            weight = Convert.ToDecimal(txtWeight.Text) - Convert.ToDecimal(txtCrystalWeight.Text);
            switch (cmbQuality.Text)
            {
                case "10k":
                    price = weight * DataStorages.price[0];
                    break;
                case "18k":
                    price = weight * DataStorages.price[1];
                    break;
                case "21k":
                    price = weight * DataStorages.price[2];
                    break;
            }

            txtbPrice.Text = Convert.ToString(price);
        }
    }
}
