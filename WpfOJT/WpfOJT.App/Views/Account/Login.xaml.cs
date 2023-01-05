using System.Windows;
using WpfOJT.App.Helpers;

namespace WpfOJT.App.Views.Account
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window,ICloseable
    {
        public Login()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}
