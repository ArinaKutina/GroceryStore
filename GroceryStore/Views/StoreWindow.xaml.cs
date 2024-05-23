using GroceryStore.DB;
using GroceryStore;
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
    /// Логика взаимодействия для StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        Logger logger = new Logger();
        GroceryStoreEntities groceryStore = new GroceryStoreEntities();
        public StoreWindow()
        {
            InitializeComponent();
            ProductsGrid.ItemsSource = groceryStore.Products.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            logger.Action("Нажата кнопка ''Корзина'' ");
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
        }
    }
}
