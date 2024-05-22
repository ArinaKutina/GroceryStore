using GroceryStore.DB;
using System;
using GroceryStoreClassLibrary;
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
using PlaidShirts;

namespace GroceryStore.Views
{
    /// <summary>
    /// Логика взаимодействия для BarcodeWindow.xaml
    /// </summary>
    public partial class BarcodeWindow : Window
    {
        Logger logger = new Logger();
        GroceryStoreEntities groceryStore = new GroceryStoreEntities();

        public BarcodeWindow()
        {
            InitializeComponent();
            ProductGrid.ItemsSource = groceryStore.ComposeOfCheck.ToList();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Поиск'' ");
            var barcode = Convert.ToInt64(SearchBox.Text);
            if (barcode != 0)
            {
                ProductGrid.ItemsSource = groceryStore.Products.Where(p => p.numBarcode == barcode).ToList();
            }
            else
            {
                MessageBox.Show("Нет товара с таким штрихкодом!");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Закрыть'' ");
            Close();
        }
    }
}
