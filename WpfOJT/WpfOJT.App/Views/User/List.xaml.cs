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

namespace WpfOJT.App.Views.User
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Page
    {
        public List()
        {
            InitializeComponent();

            this.DataContext = new UserListViewModel();
        }

        /// <summary>
        /// Navigate to user edit page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditBtn_Clicked(object sender, RoutedEventArgs e)
        {
            UserModel userModel = dataGridUser.SelectedItem as UserModel;
            this.NavigationService.Navigate(new WpfOJT.App.Views.User.Edit(userModel.Id));
        }
    }
}
