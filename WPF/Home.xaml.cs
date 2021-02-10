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

namespace WPF
{
    /// <summary>
    /// Logika interakcji dla klasy Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private RecipeBookContext context;
        public Home()
        {
            InitializeComponent();
            context = new RecipeBookContext();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {

            Check check = new Check(context);
            this.NavigationService.Navigate(check);
        }
        private void Modify_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
