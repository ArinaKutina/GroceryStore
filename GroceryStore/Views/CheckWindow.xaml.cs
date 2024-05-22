using GroceryStore.DB;
using GroceryStoreClassLibrary;
using PlaidShirts;
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

namespace GroceryStore.Views
{
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        Logger logger = new Logger();
        GroceryStoreEntities groceryStore = new GroceryStoreEntities();
        public CheckWindow()
        {
            InitializeComponent();
            CheckGrid.ItemsSource = groceryStore.ComposeOfCheck.ToList();
            ProductCountingClass productCounting = new ProductCountingClass();
            fullPriceBox.Text =  productCounting.ProductPriceCounting().ToString();
            fullNoDiscPriceBox.Text = productCounting.ProductNoDiscountCounting().ToString();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Закрыть'' ");
            Close();
        }
    }
}
