using BusinessLayer;
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
using System.Windows.Shapes;

namespace LayersVanneCrud
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void ListProducts_Click(object sender, RoutedEventArgs e)
        {
            ProductBusiness prod = new ProductBusiness();
            listproductos.ItemsSource =  prod.getProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductBusiness prod = new ProductBusiness();
            string name = txtName.Text;
            listproductos.ItemsSource = prod.getProductsByName(name);
        }
    }
}
