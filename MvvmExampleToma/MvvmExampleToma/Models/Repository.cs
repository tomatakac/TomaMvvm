using System.Collections.ObjectModel;
using Dal;
using MvvmExampleToma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmExampleToma.Models
{
    public class Repository : IRepository
    {
        private InvoiceMgrEntities _db;

        public Repository(InvoiceMgrEntities db)
        {
            _db = db;
        }

        public void AddCustomer(CustomerViewModel customer)
        {

            var customerEntity = new Customer
                {
                    Name = customer.Name,
                    Description = customer.Description,
                    PIB = customer.Pib,
                    Address = customer.Address,
                    CreatedOn = DateTime.Now
                };
            _db.Customers.Add(customerEntity);
            _db.SaveChanges();
        }

        public void AddItem(ItemViewModel item)
        {
            var itemEntity = new Item
                {
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price ?? 0,
                    CreatedOn = DateTime.Now
                };
            _db.Items.Add(itemEntity);
            _db.SaveChanges();
        }

        public ObservableCollection<ItemModel> RetrieveItems()
        {
            var collection = new ObservableCollection<ItemModel>(_db.Items
                .Select(x => new ItemModel { Id = x.Id, Name = x.Name, Price = x.Price }).ToList());
            return collection;
        }

        public ObservableCollection<CustomerModel> RetrieveCustomers()
        {
            var collection = new ObservableCollection<CustomerModel>(_db.Customers
                .Select(x => new CustomerModel { Id = x.Id, Name = x.Name }).ToList());
            return collection;
        }

        public ObservableCollection<InvoiceDetailModel> RetrieveInvoiceDetailModels(DateTime? from, DateTime? to, CustomerModel customer)
        {
            var invoiceDetailModels = new List<InvoiceDetailModel>();
            var transactions = _db.Transactions.Where(x => x.DateTime >= from || x.DateTime <= to).ToList();            
            foreach (var transaction in transactions)
            {
                var invoiceDetailModel = new InvoiceDetailModel
                {
                    TransactionId = transaction.Id,
                    Customer = transaction.CustomerItems.First().Customer.Name,
                    Date = transaction.DateTime,
                    Price = transaction.CustomerItems.Sum(x => x.Amount * x.Item.Price)
                };
                if (customer == null)
                {
                    invoiceDetailModels.Add(invoiceDetailModel);
                }
                else if (customer.Id == transaction.CustomerItems.First().Customer.Id)
                {
                    invoiceDetailModels.Add(invoiceDetailModel);
                }
            }
            return new ObservableCollection<InvoiceDetailModel>(invoiceDetailModels);
        }

        public ObservableCollection<InvoiceDetail> RetriveInvoiceDetail(InvoiceDetailModel invoiceDetail)
        {
            return new ObservableCollection<InvoiceDetail>(_db.CustomerItems
                                                              .Where(x => x.TransactionId == invoiceDetail.TransactionId)
                                                              .Select(x => new InvoiceDetail 
                                                              {
                                                                  CustomerName = x.Customer.Name,
                                                                  ItemName = x.Item.Name,
                                                                  ItemPrice = x.Item.Price,
                                                                  Amount = x.Amount
                                                              }));
        }

        public void SaveInvoice(ObservableCollection<ItemOrder> itemOrders, CustomerModel customerModel)
        {
            var transaction = new Transaction()
                {
                    DateTime = DateTime.Now
                };
            _db.Transactions.Add(transaction);

            foreach (var itemOrder in itemOrders)
            {
                var customer = _db.Customers.Single(x => x.Id == customerModel.Id);
                var item = _db.Items.Single(x => x.Id == itemOrder.Id);
                var customerItem = new CustomerItem
                {
                    Customer = customer,
                    Item = item,
                    Transaction = transaction,
                    Amount = itemOrder.Amount
                };
                _db.CustomerItems.Add(customerItem);
            }
            _db.SaveChanges();
        }
    }
}
