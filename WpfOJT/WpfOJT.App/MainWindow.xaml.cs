
using System.Windows;
using System.Windows.Input;
using WpfOJT.App.Helpers;
using WpfOJT.App.Views.Account;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;
using WpfOJT.Services.Services;

namespace WpfOJT.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,ICloseable
    {
        /// <summary>
        /// Define the _userService
        /// </summary>
        private IUserService _userService;

        /// <summary>
        /// Define the _authModel
        /// </summary>
        private LoginViewModel _authModel;
        public MainWindow()
        {
            InitializeComponent();

            _userService = new UserService();

            _authModel = new LoginViewModel();

            this.checkIsAdmin();

        }

        /// <summary>
        /// Check whether login user is admin or not
        /// </summary>
        private void checkIsAdmin()
        {
            int userId = (int)Application.Current.Properties["UserId"];
            UserViewModel user = _userService.Get(userId);
            if (user.Role == 2)
            {
                this.menuUser.Visibility = Visibility.Collapsed;
            }

        }

        /// <summary>
        /// Navigate to user list page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuUserList_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.User.List());
        }


        /// <summary>
        /// Navigate to user create page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCreateUser_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.User.Create());
        }


        /// <summary>
        /// Navigate to post list page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuPostList_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.Post.List());
        }


        /// <summary>
        /// Navigate to post create page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuCreatePost_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.Post.Create());
        }


        /// <summary>
        /// Navigate to user profile page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.User.Profile());
        }


        /// <summary>
        /// Navigate to change password page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPassBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.mainFrame.Navigate(new WpfOJT.App.Views.User.ChangePassword());
        }


        /// <summary>
        /// Trigger logout command when logout menu item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutMenu_Clicked(object sender, RoutedEventArgs e)
        {
            this.logoutMenu.Command = _authModel.LogoutCommand;
            this.logoutMenu.CommandParameter = this;
        }

        /// <summary>
        /// Trigger logout command when logout button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutBtn_Clicked(object sender, RoutedEventArgs e)
        {
            this.logoutBtn.Command = _authModel.LogoutCommand;
            this.logoutBtn.CommandParameter = this;
        }

        
    }
}
