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
    /// Логика взаимодействия для PageSelectProduct.xaml
    /// </summary>
    public partial class PageSelectProduct : Page
    {
        public PageSelectProduct()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.ToList();
        }
        
         void up()
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.ToList();
        }
      
        private void cat1_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.Where(x => x.idCategory == 1).ToList();
        }

        private void cat2_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.Where(x => x.idCategory == 2).ToList();
        }

        private void cat3_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.Where(x => x.idCategory == 3).ToList();
        }

        private void cat4_Click(object sender, RoutedEventArgs e)
        {
            Grid1.ItemsSource = ODBconnect.DB.Products.Where(x => x.idCategory == 4).ToList();
        }

        private void cat1_MouseEnter(object sender, MouseEventArgs e)
        {
            cat1.Foreground = Brushes.Black;
            
        }

        private void cat1_MouseLeave(object sender, MouseEventArgs e)
        {
            cat1.Foreground = Brushes.Red;
        }

        private void cat2_MouseEnter(object sender, MouseEventArgs e)
        {
            cat2.Foreground = Brushes.Black;
        }

        private void cat2_MouseLeave(object sender, MouseEventArgs e)
        {
            cat2.Foreground = Brushes.Red;
        }

        private void cat3_MouseEnter(object sender, MouseEventArgs e)
        {
            cat3.Foreground = Brushes.Black;
        }

        private void cat3_MouseLeave(object sender, MouseEventArgs e)
        {
            cat3.Foreground = Brushes.Red;
        }

        private void cat4_MouseEnter(object sender, MouseEventArgs e)
        {
            cat4.Foreground = Brushes.Black;
        }

        private void cat4_MouseLeave(object sender, MouseEventArgs e)
        {
            cat4.Foreground = Brushes.Red;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddProduct());
        }

        private void DelateProd_Click(object sender, RoutedEventArgs e)
        {

            var a = Grid1.SelectedItem as Products;
            ODBconnect.DB.Products.Remove(a);
            ODBconnect.DB.SaveChanges();
            up();
        }

        private void UpProd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddSales_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddSales());
        }
    }
}
