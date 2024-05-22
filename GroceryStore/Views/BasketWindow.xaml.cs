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
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        Logger logger = new Logger();
        GroceryStoreEntities groceryStore = new GroceryStoreEntities();
        public BasketWindow()
        {
            InitializeComponent();
            ProductGrid.ItemsSource = groceryStore.ComposeOfCheck.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Перейти к Чеку'' ");
            BuyWindow buyWindow = new BuyWindow();
            Close();
            buyWindow.Show();
        }
           
        private void RemoveFromBasket_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Удалить из корзины'' ");
            try
            {
                var pin = Convert.ToInt32(pincodeBox.Password);
                if (pin == 1111)
                {
                    var k = ProductGrid.SelectedItem as ComposeOfCheck;
                    if (k.count != 1)
                    {
                        var r = groceryStore.Products.Where(y => y.idProduct == k.idProduct).Single();

                        k.count = k.count - 1;
                        k.fullPrice = k.fullPrice - r.price;
                        groceryStore.SaveChanges();

                    }
                    else
                    {
                        groceryStore.ComposeOfCheck.Remove(k);
                        groceryStore.SaveChanges();
                    }
                }
                else if (pin != 1111)
                {
                    MessageBox.Show("Неправильный PIN-код!!!");
                }
            }
            catch 
            {
                MessageBox.Show("Введите PIN-код!!!");
            }
            ProductGrid.ItemsSource = groceryStore.ComposeOfCheck.ToList();
        }

        private void ToCheckButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Назад'' ");
            CheckWindow checkWindow = new CheckWindow();
            Close();
            checkWindow.Show();
        }
    }
}
