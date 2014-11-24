using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.Models
{
    public class ItemOrder : ItemModel 
    {
        public int Amount { get; set; }        
        public String OrderDetail
        {
            get
            {
                return String.Format("{0}     Amount:{1}", Name, Amount);
            }
        }
    }
}
