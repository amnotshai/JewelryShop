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
    /// Interaction logic for PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public PaymentWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            txtbName.Text =Convert.ToString( DataStorages.transaction[Counter.Count].Customer);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            decimal loanedAmount = DataStorages.transaction[Counter.Count].AmountLoan;
            decimal payment = Convert.ToDecimal(txtPayment.Text);
            decimal newValue = loanedAmount - payment;

            DataStorages.transaction[Counter.Count].AmountLoan = newValue;

            this.Close();
        }
    }
}
