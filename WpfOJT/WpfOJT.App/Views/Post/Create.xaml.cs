using System.Windows.Controls;

namespace WpfOJT.App.Views.Post
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Page
    {
        public Create()
        {
            InitializeComponent();
            this.DataContext = new PostListViewModel();
        }
    }
}
