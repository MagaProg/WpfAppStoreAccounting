#pragma checksum "..\..\..\PageStore\PageAddProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BFAB067B8DD3FA46040478C8AFA5D2FF86876787E47BCBB8988E1CADD30707AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
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
using WpfAppStoreAccounting.PageStore;


namespace WpfAppStoreAccounting.PageStore {
    
    
    /// <summary>
    /// PageAddProduct
    /// </summary>
    public partial class PageAddProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CMDCategry;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelProducts;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ManuProducts;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ManuAddresProducts;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceProducts;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuStoreProducts;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuWarehouseProducts;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SerialNumbeProducts;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameProducts;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\PageStore\PageAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProducts;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppStoreAccounting;component/pagestore/pageaddproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageStore\PageAddProduct.xaml"
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
            this.CMDCategry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ModelProducts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ManuProducts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ManuAddresProducts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PriceProducts = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\PageStore\PageAddProduct.xaml"
            this.PriceProducts.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PriceProducts_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.QuStoreProducts = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\PageStore\PageAddProduct.xaml"
            this.QuStoreProducts.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.QuStoreProducts_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.QuWarehouseProducts = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\PageStore\PageAddProduct.xaml"
            this.QuWarehouseProducts.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.QuWarehouseProducts_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SerialNumbeProducts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.nameProducts = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.AddProducts = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\PageStore\PageAddProduct.xaml"
            this.AddProducts.Click += new System.Windows.RoutedEventHandler(this.AddProducts_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

