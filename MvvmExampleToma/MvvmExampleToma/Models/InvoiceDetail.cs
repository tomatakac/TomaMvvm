using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.Models
{
    public class InvoiceDetail
    {
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int Amount { get; set; }
        public string Detail
        {
            get
            {
                return String.Format("{0}   {1}   {2}   {3}", CustomerName, ItemName, ItemPrice, Amount);
            }
        }
    }
}
