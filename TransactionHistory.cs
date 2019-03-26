using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryShop
{
    public class TransactionHistory
    {
       private decimal amountToBePayed;
        public string Customer { get; set;}
        public string Jewelry { get; set; }
        public string Quality { get; set; }
        public decimal Weight { get; set; }
        public string Price { get; set; }
        public decimal AmountToBePayed
        {
            get { return (amountToBePayed * (DataStorages.set[3]/100)) + amountToBePayed; }
            set { amountToBePayed = value; }
        }
        public string DateOfTransaction { get; set; }
        public string Details { get; set; }

    }
}
