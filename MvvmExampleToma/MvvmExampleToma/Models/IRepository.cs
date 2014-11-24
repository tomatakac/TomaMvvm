using MvvmExampleToma.ViewModels;
using System.Collections.ObjectModel;
using MvvmExampleToma.Models;

namespace MvvmExampleToma.Models
{
    public interface IRepository
    {
        void AddCustomer(CustomerViewModel customer);
        void AddItem(ItemViewModel item);
        ObservableCollection<ItemModel> RetrieveItems();
        ObservableCollection<CustomerModel> RetrieveCustomers();
        void SaveInvoice(ObservableCollection<ItemOrder> itemOrders, CustomerModel customerModel);
    }
}