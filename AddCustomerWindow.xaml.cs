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
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        public DataStorage data;
        public AddCustomerWindow()
        {
            InitializeComponent();
        }
        public void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Person customer = new Person(txtFirstName.Text, txtLastName.Text, txtMiddleName.Text);
            bool exist = false;
            foreach (Person cust in data.customers)
            {
                if (customer.GetFullName() == cust.GetFullName())
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)//if not exist add to storage
                data.customers.Add(customer);
            else
                MessageBox.Show("The name you have entered already exist in the system.");

            this.Close();
        }
    }
}
