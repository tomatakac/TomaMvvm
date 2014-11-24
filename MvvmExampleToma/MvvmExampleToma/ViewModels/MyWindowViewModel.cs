using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using MvvmExampleToma.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace MvvmExampleToma.ViewModels
{
    public class MyWindowViewModel : BindableBase
    {
        private const string SuccessMessage = "Success!";
        private ObservableCollection<CustomerModel> _customers;
        private IRepository _repo;
        private ObservableCollection<ItemModel> _items;
        private ItemOrder _selectedItem;
        private CustomerModel _selectedCustomer;
        private ObservableCollection<ItemOrder> _listBoxItems = new ObservableCollection<ItemOrder>();
        private CustomerViewModel _customer = new CustomerViewModel();
        private string _createCustomerStatus;
        private string _createItemStatus;
        private string _createInvoiceStatus;
        private ItemViewModel _item = new ItemViewModel();
        private int _spinEditValue;
        private decimal _orderPrice;

        public string CreateInvoiceStatus
        {
            get
            {
                return _createInvoiceStatus;
            }
            set
            {
                SetProperty(ref _createInvoiceStatus, value);
            } 
        }

        public decimal OrderPrice
        {
            get
            {
                return _orderPrice;
            }
            set
            {
                SetProperty(ref _orderPrice, value);
            } 
        }

        public CustomerModel SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                SetProperty(ref _selectedCustomer, value);
            } 
        }

        public int SpinEditValue
        {
            get
            {
                return _spinEditValue;
            }
            set
            {
                SetProperty(ref _spinEditValue, value);
            } 
        }

        public string CreateItemStatus
        {
            get
            {
                return _createItemStatus;
            }
            set
            {
                SetProperty(ref _createItemStatus, value);
            } 
        }

        public ItemViewModel Item
        {
            get
            {
                return _item;
            }
            set
            {
                SetProperty(ref _item, value);
            } 
        }

        public string CreateCustomerStatus
        {
            get
            {
                return _createCustomerStatus;
            }
            set
            {
                SetProperty(ref _createCustomerStatus, value);
            } 
        }

        public CustomerViewModel Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                SetProperty(ref _customer, value);
            } 
        }

        public ObservableCollection<ItemOrder> ListBoxItems 
        { 
            get 
            { 
                return _listBoxItems; 
            }
            set {
                SetProperty(ref _listBoxItems, value); 
            } 
        }

        public ItemOrder SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty(ref _selectedItem, value); }
        }

        public ICommand SelectItemCommand { get; set; }
        public ICommand AddItemsCommand { get; set; }
        public ICommand SaveCustomerCommand { get; set; }
        public ICommand SaveItemCommand { get; set; }
        public ICommand SpinEditValueChanged { get; set; }
        public ICommand SelectCustomerCommand { get; set; }
        public ICommand SaveInvoiceCommand { get; set; }

        public ObservableCollection<CustomerModel> Customers
        {
            get{
                return _customers;
            }
            set
            {
                SetProperty(ref _customers, value);
            }
        }

        public ObservableCollection<ItemModel> Items
        {
            get
            {
                return _items;
            }
            set
            {
                SetProperty(ref _items, value);
            }
        }        

        public MyWindowViewModel(IRepository repo)
        {
            _repo = repo;
            SelectItemCommand = new DelegateCommand<Object[]>(SelectItem);
            AddItemsCommand = new DelegateCommand(AddItem);
            SaveCustomerCommand = new DelegateCommand(SaveCustomer);
            SaveItemCommand = new DelegateCommand(SaveItem);
            SpinEditValueChanged = new DelegateCommand<decimal?>(SpinEditChange);
            SelectCustomerCommand = new DelegateCommand<Object[]>(SelectCustomer);
            Items = _repo.RetrieveItems();
            Customers = _repo.RetrieveCustomers();
            SaveInvoiceCommand = new DelegateCommand(SaveInvoice);
        }

        private void SaveInvoice()
        {
            _repo.SaveInvoice(ListBoxItems, SelectedCustomer);
            ListBoxItems = new ObservableCollection<ItemOrder>();
            SelectedCustomer = new CustomerModel();
            CreateInvoiceStatus = SuccessMessage;
        }

        private void SelectCustomer(object[] customers)
        {
            if (customers != null && customers.Any())
            {
                SelectedCustomer = customers.FirstOrDefault() as CustomerModel;               
            }
        }

        private void SpinEditChange(decimal? item)
        {
            if (item != null)
            {
                SpinEditValue = (int)item;               
            }
        }

        private void SaveItem()
        {
            _repo.AddItem(Item);
            Item = new ItemViewModel();
            CreateItemStatus = SuccessMessage;
            Items = _repo.RetrieveItems();
        }

        private void SaveCustomer()
        {
            //_repo.AddCustomer(Customer);
            Customer = new CustomerViewModel();
            CreateCustomerStatus = SuccessMessage;
            Customers = _repo.RetrieveCustomers();
        }

        private void AddItem()
        {
            SelectedItem.Amount = SpinEditValue;
            ListBoxItems.Add(SelectedItem);

            OrderPrice = ListBoxItems.Sum(x => x.Price * x.Amount);
        }

        private void SelectItem(object[] items)
        {
            if (items != null && items.Any())
            { 
                var itemModel =  items.FirstOrDefault() as ItemModel;
                var itemOrder = new ItemOrder
                {
                    Id = itemModel.Id,
                    Name = itemModel.Name,
                    Amount = SpinEditValue,
                    Price = itemModel.Price
                };
                SelectedItem = itemOrder;
            }
        }       
    }
}
