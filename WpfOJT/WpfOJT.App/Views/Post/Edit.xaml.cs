using System.Windows.Controls;

namespace WpfOJT.App.Views.Post
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        public Edit(int id)
        {
            InitializeComponent();
            this.DataContext = new PostListViewModel(id);
        }
    }
}
