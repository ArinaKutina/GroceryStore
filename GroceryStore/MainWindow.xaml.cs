using GroceryStore.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroceryStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Logger logger = new Logger();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StoreButton_Click(object sender, RoutedEventArgs e)
        {
            StoreWindow storeWindow = new StoreWindow();
            Close();
            storeWindow.Show();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            BuyWindow buyWindow = new BuyWindow();
            Close();
            buyWindow.Show();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BarcodeButton_Click(object sender, RoutedEventArgs e)
        {
            BarcodeWindow barcodeWindow = new BarcodeWindow();
            barcodeWindow.Show();
        }
    }
}
