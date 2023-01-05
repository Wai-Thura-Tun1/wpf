using WpfOJT.App.ViewModels;

namespace WpfOJT.App.Views.Account
{
    /// <summary>
    /// Define the <see cref="LoginModel"/>
    /// </summary>
    public class LoginModel:ViewModelBase
    {
        /// <summary>
        /// Define the _email
        /// </summary>
        private string _email { get; set; } = "";

        /// <summary>
        /// Define the Email
        /// </summary>
        public string Email
        {
            get
            {
                return this._email;
            }
            set
            {
                this._email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Define the _password
        /// </summary>
        private string _password { get; set; } = "";

        /// <summary>
        /// Define the Password
        /// </summary>
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this._password = value;
                OnPropertyChanged("Password");
            }
        }
    }
}
