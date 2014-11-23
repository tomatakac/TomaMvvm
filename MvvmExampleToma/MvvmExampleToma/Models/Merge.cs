using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.Models
{
    public class Merge : IMerge
    {
        public string Marge(int number)
        {
            return String.Format("Some number: {0}", number.ToString());
        }
    }
}
