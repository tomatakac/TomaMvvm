using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.ViewModels
{
    public class TomaViewModel : BindableBase
    {
        private ObservableCollection<String> _customers = new ObservableCollection<string>() { "ComData", "Levi9", "NsWeb" };

        public ObservableCollection<String> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                SetProperty(ref _customers, value);
            }
        }
    }
}
