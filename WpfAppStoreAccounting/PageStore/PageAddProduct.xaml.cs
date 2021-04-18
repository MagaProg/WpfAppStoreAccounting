using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppStoreAccounting.Model;

namespace WpfAppStoreAccounting.PageStore
{
    /// <summary>
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        public PageAddProduct()
        {
            InitializeComponent();
            CMDCategry.ItemsSource = ODBconnect.DB.LoadCategory.ToList();
        }

        private void AddProducts_Click(object sender, RoutedEventArgs e)
        {
            Products products = new Products()
            {
                LoadCategory=CMDCategry.SelectedItem as LoadCategory,

                Model= ModelProducts.Text,

                Manufacturer= ManuAddresProducts.Text,

                ManufacturerAddress= ManuAddresProducts.Text,

                Price=Convert.ToInt64( PriceProducts.Text),

                QuantityStore= Convert.ToInt32(QuStoreProducts.Text),

                QuantityWarehouse= Convert.ToInt32(QuWarehouseProducts.Text),

                NameProducts= nameProducts.Text,

                SerialNumber= SerialNumbeProducts.Text

            };

            ODBconnect.DB.Products.Add(products);
            ODBconnect.DB.SaveChanges();
        }

        private void PriceProducts_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890".IndexOf(e.Text) < 0;
        }

        private void QuStoreProducts_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890".IndexOf(e.Text) < 0;
        }

        private void QuWarehouseProducts_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890".IndexOf(e.Text) < 0;
        }
    }
    
}
