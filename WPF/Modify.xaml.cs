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
using WPFLib.DAL;
using WPFLib.Model;

namespace WPF
{
    /// <summary>
    /// Logika interakcji dla klasy Modify.xaml
    /// Dodawanie usuwanie przepisow, produktow.
    /// </summary>
    public partial class Modify : Page
    {
        private readonly RecipeBookContext _context;
        public Modify(RecipeBookContext context)
        {
            InitializeComponent();

            this._context = context;

            productTypeComboBox.ItemsSource = _context.ProductTypes.ToList();
            recipeList.ItemsSource = _context.Dishes.ToList();
            productList.ItemsSource = _context.Products.ToList();
            dishTypeComboBox.ItemsSource = _context.DishTypes.ToList();
        }

        private void addProductBtn_Click(object sender, RoutedEventArgs e)
        {
            var productName = productNameTB.Text;
            var category = productTypeComboBox.Text;

            if (productTypeComboBox.SelectedItem != null)
            {
                var productType = new ProductType { Type = category };
             
                var product = new Product { Name = productName, ProductType = productType };
                _context.Products.Add(product);
                _context.SaveChanges();
                productList.ItemsSource = _context.Products.ToList();
            }
            else
            {
                MessageBox.Show("Prosze wybrac typ produkt.");
            }
        }

        private void moveToRightBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = productList.SelectedItem;
            if (!newRecipeProductList.Items.Contains(item))
                newRecipeProductList.Items.Add(item);
        }

        private void moveToLeftBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = newRecipeProductList.SelectedItem;
            newRecipeProductList.Items.Remove(item);
        }

        private void addRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            var products = new List<Product>();
            foreach (var item in newRecipeProductList.Items)
            {
                products.Add(item as Product);
            }

            var recipeName = recipeNameTB.Text;
            var desc = descriptonTB.Text;
            var dishType = dishTypeComboBox.SelectedItem as DishType;

            var dish = new Dish { Name = recipeName, Products = products, 
                Description = desc, DishType = dishType};

            _context.Dishes.Add(dish);
            _context.SaveChanges();

            productList.ItemsSource = _context.Dishes.ToList();
        }

        private void removeRecipeBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = recipeList.SelectedItem as Dish;

            _context.Dishes.Remove(item);
            _context.SaveChanges();

            recipeList.ItemsSource = _context.Dishes.ToList();
        }

        private void removeProductBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = productList.SelectedItem as Product;

            _context.Products.Remove(item);
            _context.SaveChanges();

            productList.ItemsSource = _context.Products.ToList();
        }

        private void productNameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = String.Empty;
            ((TextBox)sender).GotFocus -= productNameTB_GotFocus;
        }

        private void recipeNameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = String.Empty;
            ((TextBox)sender).GotFocus -= recipeNameTB_GotFocus;
        }

        private void descriptonTB_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Text = String.Empty;
            ((TextBox)sender).GotFocus -= descriptonTB_GotFocus;
        }
    }
}
