﻿#pragma checksum "..\..\..\Views\MyWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7E0D903D1048AF9765582BD938DBE7C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Ribbon;
using Microsoft.Practices.Prism.Interactivity;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MvvmExampleToma.Views {
    
    
    /// <summary>
    /// MyWindow
    /// </summary>
    public partial class MyWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem customerBarButtonItem;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem itemBarButtonItem;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem barButtonItem1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem barButtonItem2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem Invoice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Bars.BarButtonItem invoiceBarButtonItem;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CustomerGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PibTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressTextBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ItemGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ItemDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid InvoiceGrid;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox itemsComboBox;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ItemsListBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Views\MyWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CustomersComboBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MvvmExampleToma;component/views/mywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MyWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.customerBarButtonItem = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            
            #line 14 "..\..\..\Views\MyWindow.xaml"
            this.customerBarButtonItem.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(this.customerBarButtonItem_ItemClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.itemBarButtonItem = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            
            #line 15 "..\..\..\Views\MyWindow.xaml"
            this.itemBarButtonItem.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(this.itemBarButtonItem_ItemClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.barButtonItem1 = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            return;
            case 4:
            this.barButtonItem2 = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            return;
            case 5:
            this.Invoice = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            return;
            case 6:
            this.invoiceBarButtonItem = ((DevExpress.Xpf.Bars.BarButtonItem)(target));
            
            #line 19 "..\..\..\Views\MyWindow.xaml"
            this.invoiceBarButtonItem.ItemClick += new DevExpress.Xpf.Bars.ItemClickEventHandler(this.invoiceBarButtonItem_ItemClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CustomerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.PibTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.AddressTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.ItemGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            this.ItemNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.ItemDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.InvoiceGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.itemsComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 18:
            this.ItemsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 19:
            this.CustomersComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

