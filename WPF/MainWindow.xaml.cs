using System.Data.Entity;
using System.Windows.Navigation;
using WPFLib.DAL;

namespace WPF
{
    /// <summary>
    /// Inicjalizacja okna oraz bazy danych, jezeli pusta.
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Database.SetInitializer(new RecipeBookInitializer());
        }
    }
}
