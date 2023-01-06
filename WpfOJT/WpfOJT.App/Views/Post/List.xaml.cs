
using Microsoft.Win32;
using System;
using System.Windows.Controls;

namespace WpfOJT.App.Views.Post
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Page
    {
        /// <summary>
        /// Define the _postListViewModel
        /// </summary>
        private PostListViewModel _postListViewModel;
        public List()
        {
            InitializeComponent();
            _postListViewModel = new PostListViewModel();
            this.DataContext = _postListViewModel;
        }

        /// <summary>
        /// Navigate to post edit page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            PostModel postModel = dataGridPost.SelectedItem as PostModel;
            if (postModel != null)
            {
                this.NavigationService.Navigate(new WpfOJT.App.Views.Post.Edit(postModel.Id));
            }

        }

        /// <summary>
        /// Trigger file dialog and call upload function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uploadBtn_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx,*.xls)|*.xlsx;*.xls";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (ofd.ShowDialog() == true)
            {
                string filePath = ofd.FileName;
                _postListViewModel.Upload(filePath);
            }
        }
    }
}
