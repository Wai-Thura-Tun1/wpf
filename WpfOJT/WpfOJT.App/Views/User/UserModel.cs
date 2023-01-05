using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfOJT.App.ViewModels;
using WpfOJT.Entities.DTO;

namespace WpfOJT.App.Views.User
{
    public class UserModel:ViewModelBase
    {
        /// <summary>
        /// Define the _id
        /// </summary>
        private int _id;

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
        /// Define the _firstname
        /// </summary>
        private string _firstname = "";

        /// <summary>
        /// Define the FirstName
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Define the _lastname
        /// </summary>
        private string _lastname = "";

        /// <summary>
        /// Define the LastName
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Define the _fullname
        /// </summary>
        private string _fullname = "";

        /// <summary>
        /// Define the FullName
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = value;
                OnPropertyChanged("FullName");
            }
        }

        /// <summary>
        /// Define the _email
        /// </summary>
        private string _email = "";

        /// <summary>
        /// Define the Email
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        /// <summary>
        /// Define the _password
        /// </summary>
        private string _password = "";

        /// <summary>
        /// Define the Password
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        /// <summary>
        /// Define the _confirmpass
        /// </summary>
        private string _confirmpass = "";

        /// <summary>
        /// Define the ConfirmPass
        /// </summary>
        public string ConfirmPass
        {
            get
            {
                return _confirmpass;
            }
            set
            {
                _confirmpass = value;
                OnPropertyChanged("ConfirmPass");
            }
        }

        /// <summary>
        /// Define the _oldPass
        /// </summary>
        private string _oldPass = "";

        /// <summary>
        /// Define the OldPass
        /// </summary>
        public string OldPass
        {
            get
            {
                return _oldPass;
            }
            set
            {
                _oldPass = value;
                OnPropertyChanged("OldPass");
            }
        }

        /// <summary>
        /// Define the _phone
        /// </summary>
        private string _phone = "";

        /// <summary>
        /// Define the Phone
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// Define the _role
        /// </summary>
        private int _role;

        /// <summary>
        /// Define the Role
        /// </summary>
        public int Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
                OnPropertyChanged("Role");
            }
        }

        /// <summary>
        /// Define the _srole
        /// </summary>
        private string _srole = "";

        /// <summary>
        /// Define the SRole
        /// </summary>
        public string SRole
        {
            get
            {
                return _srole;
            }
            set
            {
                _srole = value;
                OnPropertyChanged("SRole");
            }
        }

        /// <summary>
        /// Define the _sdob
        /// </summary>
        private string _sdob = "";

        /// <summary>
        /// Define the SDob
        /// </summary>
        public string SDob
        {
            get
            {
                return _sdob;
            }
            set
            {
                _sdob = value;
                OnPropertyChanged("SDob");
            }
        }

        /// <summary>
        /// Define the _address
        /// </summary>
        private string _address = "";

        /// <summary>
        /// Define the Address
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Define the _isactive
        /// </summary>
        private bool _isactive;

        /// <summary>
        /// Define the IsActive
        /// </summary>
        public bool IsActive
        {
            get
            {
                return _isactive;
            }
            set
            {
                _isactive = value;
                OnPropertyChanged("IsActive");
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
        /// Define the _users
        /// </summary>
        private ObservableCollection<UserModel> _users;

        /// <summary>
        /// Define the Users
        /// </summary>
        public ObservableCollection<UserModel> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        /// <summary>
        /// Define the _roles
        /// </summary>
        private ObservableCollection<RoleModel> _roles;

        /// <summary>
        /// Define the Roles
        /// </summary>
        public ObservableCollection<RoleModel> Roles
        {
            get
            {
                return _roles;
            }
            set
            {
                _roles = value;
                OnPropertyChanged("Roles");
            }
        }

    }
}
