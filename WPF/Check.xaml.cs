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
    /// Logika interakcji dla klasy Check.xaml
    /// </summary>
    public partial class Check : Page
    {
        private RecipeBookContext context;

        public Check(RecipeBookContext context) : base()
        {
            InitializeComponent();
            this.context = context;

            recipeList.ItemsSource = context.Dishes.ToList();
        }

        private void recipeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            descriptionList.Text = (recipeList.SelectedItem as Dish).Description;
            producsList.ItemsSource = (recipeList.SelectedItem as Dish).Products;
        }

    }
}
