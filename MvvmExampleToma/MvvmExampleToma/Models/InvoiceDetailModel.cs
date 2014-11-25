using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.Models
{
    public class InvoiceDetailModel
    {
        public int TransactionId { get; set; }
        public String Customer { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public String Detail {
            get 
            { 
                return String.Format("{0}  {1}  {2}", Customer, Date, Price); 
            } 
        }
    }
}
