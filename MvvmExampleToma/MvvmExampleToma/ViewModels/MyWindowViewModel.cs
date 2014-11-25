using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using MvvmExampleToma.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;

namespace MvvmExampleToma.ViewModels
{
    public class MyWindowViewModel : BindableBase
    {
        #region Private properties
        public ICommand NotificationCommand { get; set; }
        private const string SuccessMessage = "Success!";
        private ObservableCollection<CustomerModel> _customers;
        private ObservableCollection<CustomerModel> _overviewCustomers;
        private IRepository _repo;
        private ObservableCollection<ItemModel> _items;
        private ItemOrder _selectedItem;
        private CustomerModel _selectedCustomer;
        private CustomerModel _selectedOverviewCustomer;
        private ObservableCollection<ItemOrder> _listBoxItems = new ObservableCollection<ItemOrder>();
        private CustomerViewModel _customer = new CustomerViewModel();
        private string _createCustomerStatus;
        private string _createItemStatus;
        private string _createInvoiceStatus;
        private ItemViewModel _item = new ItemViewModel();
        private int _spinEditValue = 1;
        private decimal? _orderPrice;
        private DateTime? _fromDate;
        private DateTime? _toDate;
        private ObservableCollection<InvoiceDetailModel> _invoiceDetailModels;
        private InvoiceDetailModel _invoiceDetailModel;
        private ObservableCollection<InvoiceDetail> _invoiceDetails;
        #endregion               

        #region Public properties

        public InteractionRequest<INotification> NotificationRequest { get; set; }

        public ObservableCollection<InvoiceDetail> InvoiceDetails
        {
            get
            {
                return _invoiceDetails;
            }
            set
            {
                SetProperty(ref _invoiceDetails, value);
            }
        }

        public InvoiceDetailModel InvoiceDetailModel
        {
            get
            {
                return _invoiceDetailModel;
            }
            set
            {
                SetProperty(ref _invoiceDetailModel, value);
            }
        }

        public ObservableCollection<InvoiceDetailModel> InvoiceDetailModels
        {
            get
            {
                return _invoiceDetailModels;
            }
            set
            {
                SetProperty(ref _invoiceDetailModels, value);
            }
        }

        public DateTime? ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                SetProperty(ref _toDate, value);
            }
        }

        public DateTime? FromDate
        {
            get
            {
                return _fromDate;
            }
            set
            {
                SetProperty(ref _fromDate, value);
            } 
        }

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

        public decimal? OrderPrice
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

        public CustomerModel SelectedOverviewCustomer
        {
            get
            {
                return _selectedOverviewCustomer;
            }
            set
            {
                SetProperty(ref _selectedOverviewCustomer, value);
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

        public ObservableCollection<CustomerModel> OverviewCustomers
        {
            get
            {
                return _overviewCustomers;
            }
            set
            {
                SetProperty(ref _overviewCustomers, value);
            }
        }

        public ObservableCollection<CustomerModel> Customers
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
        #endregion

        #region Command declarations
        public ICommand SelectItemCommand { get; set; }
        public ICommand AddItemsCommand { get; set; }
        public ICommand SaveCustomerCommand { get; set; }
        public ICommand SaveItemCommand { get; set; }
        public ICommand SpinEditValueChanged { get; set; }
        public ICommand SelectCustomerCommand { get; set; }
        public ICommand SaveInvoiceCommand { get; set; }
        public ICommand FromDateChangedCommand { get; set; }
        public ICommand ToDateChangedCommand { get; set; }
        public ICommand FilterCommand { get; set; }
        public ICommand OverviewCustomerCommand { get; set; }
        public ICommand SelectInvoiceDetailCommand { get; set; }
        #endregion

        #region Constructor
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
            OverviewCustomers = _repo.RetrieveCustomers();
            SaveInvoiceCommand = new DelegateCommand(SaveInvoice);
            FromDateChangedCommand = new DelegateCommand<DateTime?>(FromDateChanged);
            ToDateChangedCommand = new DelegateCommand<DateTime?>(ToDateChanged);
            FilterCommand = new DelegateCommand(FilterCom);
            OverviewCustomerCommand = new DelegateCommand<Object[]>(OverviewCustomer);
            SelectInvoiceDetailCommand = new DelegateCommand<Object[]>(SelectInvoiceDetail);
            NotificationRequest = new InteractionRequest<INotification>();
            NotificationCommand = new DelegateCommand(RaiseNotification);
        }

        private void RaiseNotification()
        {
            NotificationRequest.Raise(new Notification{Content = "Error", Title="ErrorOccured"});
        }
        #endregion

        #region Delegate methods
        private void SelectInvoiceDetail(object[] items)
        {
            if (items != null && items.Any())
            {
                InvoiceDetailModel = items.FirstOrDefault() as InvoiceDetailModel;
                InvoiceDetails = _repo.RetriveInvoiceDetail(InvoiceDetailModel);
            }
        }

        private void OverviewCustomer(object[] customers)
        {
            if (customers != null && customers.Any())
            {
                SelectedOverviewCustomer = customers.FirstOrDefault() as CustomerModel;
            }
        }

        private void FilterCom()
        {
            InvoiceDetailModels = _repo.RetrieveInvoiceDetailModels(FromDate, ToDate, SelectedOverviewCustomer);
        }

        private void ToDateChanged(DateTime? date)
        {
            ToDate = date;
        }

        private void FromDateChanged(DateTime? date)
        {
            FromDate = date;
        }

        private void SaveInvoice()
        {
            try
            {
                _repo.SaveInvoice(ListBoxItems, SelectedCustomer);
                ListBoxItems = new ObservableCollection<ItemOrder>();
                SelectedCustomer = new CustomerModel();
                CreateInvoiceStatus = SuccessMessage;
                Items = _repo.RetrieveItems();
                Customers = _repo.RetrieveCustomers();
                SpinEditValue = 1;
                OrderPrice = null;
                MessageDelay();
            }
            catch (Exception ex)
            {
                NotificationCommand.Execute(null);
            }
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
            try
            {
                _repo.AddItem(Item);
                Item = new ItemViewModel();
                CreateItemStatus = SuccessMessage;
                Items = _repo.RetrieveItems();
                MessageDelay();
            }
            catch (Exception ex)
            {
               NotificationCommand.Execute(null);
            }
        }

        private void SaveCustomer()
        {
            try
            {
                _repo.AddCustomer(Customer);
                Customer = new CustomerViewModel();
                CreateCustomerStatus = SuccessMessage;
                Customers = _repo.RetrieveCustomers();
                OverviewCustomers = _repo.RetrieveCustomers();
                MessageDelay();
            }
            catch (Exception ex)
            {
                NotificationCommand.Execute(null);
            }           
        }

        private async void MessageDelay()
        {
            await Task.Delay(3000);
            CreateInvoiceStatus = String.Empty;
            CreateItemStatus = String.Empty;
            CreateCustomerStatus = String.Empty;
        }

        private void AddItem()
        {
            SelectedItem.Amount = SpinEditValue;
            ListBoxItems.Add(SelectedItem);

            OrderPrice = ListBoxItems.Sum(x => x.Price * x.Amount) ?? 0;
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
        #endregion
    }
}
