using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOJT.App.ViewModels
{
    /// <summary>
    /// Define the <see cref="MainViewModel"/>
    /// </summary>
    public class MainViewModel:ViewModelBase
    {
        /// <summary>
        /// Define the _instance 
        /// </summary>
        private static MainViewModel _instance = new MainViewModel();

        /// <summary>
        /// Define the Instance
        /// </summary>
        public static MainViewModel Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Define the _pagePath
        /// </summary>
        private string _pagePath;

        /// <summary>
        /// Define the PagePath
        /// </summary>
        public string PagePath
        {
            get
            {
                return _pagePath;
            }
            set
            {
                _pagePath = value;
                OnPropertyChanged("PagePath");
            }
        }
    }
}
