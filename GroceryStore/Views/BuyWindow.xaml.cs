using GroceryStore.DB;
using GroceryStoreClassLibrary;
using PlaidShirts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GroceryStore.Views
{
    /// <summary>
    /// Логика взаимодействия для BuyWindow.xaml
    /// </summary>
    public partial class BuyWindow : Window
    {
        Logger logger = new Logger();
        GroceryStoreEntities groceryStore = new GroceryStoreEntities();
        ProductCountingClass productCountingClass = new ProductCountingClass();
        public BuyWindow()
        {
            InitializeComponent();
            ProductGrid.ItemsSource = groceryStore.Products.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Назад'' ");
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }

        private void AddToBasket_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Добавить в корзину'' ");
            BuyButton.Visibility = Visibility.Visible;
            var x = ProductGrid.SelectedItem as Products;
            try
            {
                var r = groceryStore.ComposeOfCheck.Where(y => y.idProduct == x.idProduct).Single();
                r.count++;
                r.fullPrice = productCountingClass.ProductDiscountCounting(x.price, x.discount) * r.count;
                
            }
            catch
            {
                ComposeOfCheck composeOfCheck = new ComposeOfCheck()
                {
                    idProduct = x.idProduct,
                    count = 1,
                    price = x.price,
                    fullPrice = productCountingClass.ProductDiscountCounting(x.price, x.discount)
                };
                groceryStore.ComposeOfCheck.Add(composeOfCheck);
            }
            finally
            {
                groceryStore.SaveChanges();
            }
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Перейти в корзину'' ");
            BasketWindow basketWindow = new BasketWindow();
            Close();
            basketWindow.Show();
        }


    }
}
