using System.Windows;
using System.Windows.Controls;

namespace WpfOJT.App.Views.User
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        private int result = (int)Application.Current.Properties["UserId"];
        public Profile()
        {
            InitializeComponent();
            this.DataContext = new UserListViewModel(result);
        }

        /// <summary>
        /// Navigate to user edit page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WpfOJT.App.Views.User.Edit(result));
        }
    }
}
