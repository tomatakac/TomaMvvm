using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MvvmExampleToma.Views
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window, IView
    {
        public MyWindow()
        {
            InitializeComponent();
        }     
   
        private void customerBarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            SetGridVisibilityToColapsed();          
            CustomerGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void itemBarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            SetGridVisibilityToColapsed();
            ItemGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void invoiceBarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            SetGridVisibilityToColapsed();
            InvoiceGrid.Visibility = System.Windows.Visibility.Visible;
        }

        private void SetGridVisibilityToColapsed()
        {
            CustomerGrid.Visibility = System.Windows.Visibility.Collapsed;
            ItemGrid.Visibility = System.Windows.Visibility.Collapsed;
            InvoiceGrid.Visibility = System.Windows.Visibility.Collapsed; 
        }
    }
}