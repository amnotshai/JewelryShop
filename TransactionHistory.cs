using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryShop
{
    public class TransactionHistory
    {
        public string Customer { get; set;}
        public string Jewelry { get; set; }
        public string Quality { get; set; }
        public decimal Weight { get; set; }
        public string Price { get; set; }
        public decimal AmountLoan { get; set; }
        public string DateOfTransaction { get; set; }
        public string Details { get; set; }

    }
}
