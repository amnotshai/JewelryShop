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
        
        public string name = "";
        public decimal price;
        public DataStorage data;
        public Person customer;
        public decimal discount;
        


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
            //Calculate newTransact = new Calculate();
            //newTransact.Price = Convert.ToDecimal(txtbPrice.Text);
            TransactionHistory transact = new TransactionHistory();
           
            transact.Customer = cmbCustomers.Text;
            transact.Jewelry = cmbProduct.Text;
            transact.Quality = cmbQuality.Text;
            transact.Weight = Convert.ToDecimal(txtWeight.Text);
            transact.Price = txtbPrice.Text;
            transact.AmountToBePayed= Convert.ToDecimal(txtbPrice.Text);
            transact.DateOfTransaction = Convert.ToString(TransactDate.Text);
            transact.Details = txtDetails.Text;

            DataStorages.transaction.Add(transact);
            
            this.Hide();
        }


        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {

            AddCustomerWindow newCustomer = new AddCustomerWindow();
            newCustomer.data = data;
            newCustomer.Show();
        }

        private void TxtCrystalWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            switch (cmbQuality.Text)
            {
                case "10k":
                    discount = DataStorages.set[0] * (Convert.ToDecimal(txtDiscount.Text)/100);
                    price = (DataStorages.set[0]*Convert.ToDecimal(txtWeight.Text))-(Convert.ToDecimal(txtWeight.Text)*discount);
                    break;
                case "18k":
                    discount = DataStorages.set[1] * (Convert.ToDecimal(txtDiscount.Text) / 100);
                    price = (DataStorages.set[1] * Convert.ToDecimal(txtWeight.Text)) - (Convert.ToDecimal(txtWeight.Text) * discount);
                    break;
                case "21k":
                    discount = DataStorages.set[2] * (Convert.ToDecimal(txtDiscount.Text) / 100);
                    price = (DataStorages.set[2] * Convert.ToDecimal(txtWeight.Text)) - (Convert.ToDecimal(txtWeight.Text) * discount);
                    break;
            }

            txtbPrice.Text =Convert.ToString(price);
            
        }

    }
    public class Calculate
    {
        public decimal Price { get; set; }

        public decimal CalculateAmountLoan()
        {
            return Price * (90 / 100);
        }

        public decimal CalculateAmountToBePayed()
        {
            return (Price * (90 / 100)) + (Price * (90 / 100) * DataStorages.set[3]);
        }
    }
}
