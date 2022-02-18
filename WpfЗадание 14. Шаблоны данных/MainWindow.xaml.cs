using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfЗадание_14.Шаблоны_данных
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    


    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Хлеб",
                ProdPrice = 50,
                ProdImage = "Data/хлеб.jpg",
                ProdType = Product.ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProdName = "Молоко",
                ProdPrice = 75,
                ProdImage = "Data/молоко.jpg",
                ProdType = Product.ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProdName = "Чайник",
                ProdPrice = 2000,
                ProdImage = "Data/чайник.jpg",
                ProdType = Product.ProductTypes.Appliance
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 9000,
                ProdImage = "Data/пылесос.jpg",
                ProdType = Product.ProductTypes.Appliance
            });

            lstBox.ItemsSource = products;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProdName = "Костюм",
                ProdPrice = 50000,
                ProdImage = "Data/пылесос.jpg",
                ProdType = Product.ProductTypes.Appliance
            });
        }


    }
}
