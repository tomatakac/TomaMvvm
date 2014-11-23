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
        private ObservableCollection<String> _customers = new ObservableCollection<string>() { "ComData", "Levi9", "NsWeb" };
        private string _content = "My contenet";
        private IMerge _merge;
        private ObservableCollection<String> _items = new ObservableCollection<string>(){ "Hard Disc", "Processor", "CD Rom"};
        private string _selectedItem = "None";
        private ObservableCollection<String> _listBoxItems = new ObservableCollection<string>();

        public ObservableCollection<String> ListBoxItems 
        { 
            get 
            { return _listBoxItems; }
            set {
                SetProperty(ref _listBoxItems, value); 
            } 
        }

        public String SelectedItem
        {
            get { return _selectedItem; }
            set { SetProperty<string>(ref _selectedItem, value); }
        }

        public ICommand SelectItemCommand { get; set; }
        public ICommand AddItemsCommand { get; set; }

        public ObservableCollection<String> Customers
        {
            get{
                return _customers;
            }
            set
            {
                SetProperty(ref _customers, value);
            }
        }

        public ObservableCollection<String> Items
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

        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                SetProperty(ref _content, value);
            }
        }

        public MyWindowViewModel()
        {
            SelectItemCommand = new DelegateCommand<Object[]>(SelectItem);
            AddItemsCommand = new DelegateCommand(AddItem);
        }

        private void AddItem()
        {
            ListBoxItems.Add(SelectedItem);
        }

        private void SelectItem(object[] items)
        {
            if (items != null && items.Count() > 0)
            {
                _selectedItem = items.FirstOrDefault().ToString();
            }
        }
    }
}
