using System.Windows.Controls;

namespace WpfOJT.App.Views.User
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        public ChangePassword()
        {
            InitializeComponent();
            this.DataContext = new UserListViewModel();
        }

    
    }
}
