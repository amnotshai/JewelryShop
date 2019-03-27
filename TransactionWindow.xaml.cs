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
    /// Interaction logic for TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        DataStorage data = new DataStorage();
        
        
        public TransactionWindow()
        {
            InitializeComponent();
            
        }

        private void AddTransaction_Click(object sender, RoutedEventArgs e)
        {
            AddTransactionWindow AddTransaction = new AddTransactionWindow();
            AddTransaction.data = data;
            AddTransaction.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dgTransactionHistory.Items.Clear();
            for (int x = 0; x < DataStorages.transaction.Count; x++)
            {
                dgTransactionHistory.Items.Add(DataStorages.transaction[x]);
            }
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            if (dgTransactionHistory.SelectedIndex >= 0 && dgTransactionHistory.SelectedIndex <= DataStorages.transaction.Count)
            {
                if ((DataStorages.transaction[dgTransactionHistory.SelectedIndex].AmountToBePayed == 0)||(DataStorages.transaction[dgTransactionHistory.SelectedIndex].AmountToBePayed<0))
                {
                    MessageBox.Show("Transaction is fully paid.");
                }
                else
                {
                    Counter.Count = dgTransactionHistory.SelectedIndex;
                    PaymentWindow NewPayment = new PaymentWindow();
                    NewPayment.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Please Select a Transaction");
            }
                

        }

    }
    public static class Counter
    {
        public static int Count { get; set; }
    }
}
