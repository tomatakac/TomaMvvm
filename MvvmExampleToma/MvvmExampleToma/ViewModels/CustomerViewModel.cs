using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExampleToma.ViewModels
{
    public class CustomerViewModel : BindableBase
    {
        private string _name;
        private string _description;
        private string _pib;
        private string _address;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty(ref _name, value);
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                SetProperty(ref _description, value);
            }
        }

        public string Pib
        {
            get
            {
                return _pib;
            }
            set
            {
                SetProperty(ref _pib, value);
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                SetProperty(ref _address, value);
            }
        }
    }
}
