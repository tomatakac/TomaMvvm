using System.Collections.ObjectModel;
using Dal;
using MvvmExampleToma.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Price = item.Price,
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

        public void SaveInvoice(ObservableCollection<ItemOrder> itemOrders, CustomerModel customerModel)
        {
            var transaction = new Transaction()
            {
                DateTime = DateTime.Now
            };
            _db.Transactions.Add(transaction);

            foreach(var itemOrder in itemOrders)
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
