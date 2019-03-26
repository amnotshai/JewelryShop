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
    /// Interaction logic for Price_Setter.xaml
    /// </summary>
    public partial class Price_Setter : Window
    {
        public Price_Setter()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            decimal[] settings = new decimal[4];
            settings[0] = Convert.ToDecimal(Txt10k.Text);
            settings[1] = Convert.ToDecimal(Txt18k.Text);
            settings[2] = Convert.ToDecimal(Txt21k.Text);
            settings[3] = Convert.ToDecimal(txtInterest.Text);

            for (int x = 0; x < settings.Length; x++)
            {
                DataStorages.set.Add(settings[x]);
            }
            this.Close();
        }
    }
}
