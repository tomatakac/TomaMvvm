using MvvmExampleToma.ViewModels;
using System.Collections.ObjectModel;
using MvvmExampleToma.Models;
using System;

namespace MvvmExampleToma.Models
{
    public interface IRepository
    {
        void AddCustomer(CustomerViewModel customer);
        void AddItem(ItemViewModel item);
        ObservableCollection<ItemModel> RetrieveItems();
        ObservableCollection<CustomerModel> RetrieveCustomers();
        void SaveInvoice(ObservableCollection<ItemOrder> itemOrders, CustomerModel customerModel);
        ObservableCollection<InvoiceDetailModel> RetrieveInvoiceDetailModels(DateTime? from, DateTime? to, CustomerModel customer);
        ObservableCollection<InvoiceDetail> RetriveInvoiceDetail(InvoiceDetailModel invoiceDetail);
    }
}