using System.Collections.ObjectModel;
using WpfOJT.App.ViewModels;

namespace WpfOJT.App.Views.Post
{
    /// <summary>
    /// Define the <see cref="PostModel"/>
    /// </summary>
    public class PostModel:ViewModelBase
    {
        /// <summary>
        /// Define the _id
        /// </summary>
        private int _id = 0;

        /// <summary>
        /// Define the Id
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }

        }

        /// <summary>
        /// Define the _title
        /// </summary>
        private string _title = "";

        /// <summary>
        /// Define the Title
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Define the _description
        /// </summary>
        private string _description = "";
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Define the _isPublished
        /// </summary>
        private bool _isPublished;

        /// <summary>
        /// Define the IsPublished
        /// </summary>
        public bool IsPublished
        {
            get
            {
                return _isPublished;
            }
            set
            {
                _isPublished = value;
                OnPropertyChanged("IsPublished");
            }
        }

        /// <summary>
        /// Define the _status
        /// </summary>
        private string _status = "";

        /// <summary>
        /// Define the Status
        /// </summary>
        public string Status 
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Define the _keyword
        /// </summary>
        private string _keyword = "";

        /// <summary>
        /// Define the Keyword
        /// </summary>
        public string Keyword
        {
            get
            {
                return _keyword;
            }
            set
            {
                _keyword = value;
                OnPropertyChanged("Keyword");
            }
        }

        /// <summary>
        /// Define the _createdAt
        /// </summary>
        private string _createdat = "";

        /// <summary>
        /// Define the CreatedAt
        /// </summary>
        public string CreatedAt
        {
            get
            {
                return _createdat;
            }
            set
            {
                _createdat = value;
                OnPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Define the _createdBy
        /// </summary>
        private string _createdby = "";

        /// <summary>
        /// Define the CreatedBy
        /// </summary>
        public string CreatedBy
        {
            get
            {
                return _createdby;
            }
            set
            {
                _createdby = value;
                OnPropertyChanged("CreatedBy");
            }
        }

        /// <summary>
        /// Define the _posts
        /// </summary>
        private ObservableCollection<PostModel> _posts;

        /// <summary>
        /// Define the Posts
        /// </summary>
        public ObservableCollection<PostModel> Posts
        {
            get
            {
                return _posts;
            }
            set
            {
                _posts = value;
                OnPropertyChanged("Posts");
            }
        }
    }
}
