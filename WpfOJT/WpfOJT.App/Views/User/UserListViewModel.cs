using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfOJT.App.Helpers;
using WpfOJT.App.ViewModels;
using WpfOJT.DAO.Helpers;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;
using WpfOJT.Services.Services;

namespace WpfOJT.App.Views.User
{
    public class UserListViewModel:ViewModelBase
    {
        /// <summary>
        /// Define the loginId
        /// </summary>
        private int loginId;

        /// <summary>
        /// Define the _userService
        /// </summary>
        private IUserService _userService;

        /// <summary>
        /// Define the _roleService
        /// </summary>
        private IRoleService _roleService;

        /// <summary>
        /// Define the _searchCommand
        /// </summary>
        private ICommand _searchCommand;

        /// <summary>
        /// Define the _createUserCommand
        /// </summary>
        private ICommand _createUserCommand;

        /// <summary>
        /// Define the _cancelCommand
        /// </summary>
        private ICommand _cancelCommand;

        /// <summary>
        /// Define the _saveCommand
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Define the _deleteUserCommand
        /// </summary>
        private ICommand _deleteUserCommand;

        /// <summary>
        /// Define the _changePassCommand
        /// </summary>
        private ICommand _changePassCommand;

        /// <summary>
        /// Define the ChangePassCommand
        /// </summary>
        public ICommand ChangePassCommand
        {
            get
            {
                if (_changePassCommand == null)
                {
                    _changePassCommand = new RelayCommand((param) => ChangedPass(),null);
                }
                return _changePassCommand;
            }
        }

        /// <summary>
        /// Define the DeleteCommand
        /// </summary>
        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteUserCommand == null)
                {
                    _deleteUserCommand = new RelayCommand((param) => Delete((int)param), null);
                }
                return _deleteUserCommand;
            }
            
        }

        /// <summary>
        /// Define the SaveCommand
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand((param) => Save(), null);
                }
                return _saveCommand;
            }
        }

        /// <summary>
        /// Define the CancelCommand
        /// </summary>
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand((param) => Cancel(),null);
                }
                return _cancelCommand;
            }
        }

        /// <summary>
        /// Define the CreateUserCommand
        /// </summary>
        public ICommand CreateUserCommand
        {
            get
            {
                if (_createUserCommand == null)
                {
                    _createUserCommand = new RelayCommand((param) => CreateUser(),null);
                }
                return _createUserCommand;
            }
        }

        /// <summary>
        /// Define the SearchCommand
        /// </summary>
        public ICommand SearchCommand
        {
            get
            {
                if(_searchCommand == null)
                {
                    _searchCommand = new RelayCommand((param) => Search((string)param),null);
                }
                return _searchCommand;
            }
        }

        /// <summary>
        /// Define the User
        /// </summary>
        public UserModel User { get; set; }

        public UserListViewModel()
        {
            _userService = new UserService();
            _roleService = new RoleService();
            User = new UserModel();
            loginId = (int)Application.Current.Properties["UserId"];
            GetRole();
            GetAll();
        }

        public UserListViewModel(int id)
        {
            _userService = new UserService();
            _roleService = new RoleService();
            User = new UserModel();
            loginId = (int)Application.Current.Properties["UserId"];
            GetRole();
            Get(id);
        }

        /// <summary>
        /// Navigate to user list page
        /// </summary>
        private void Cancel()
        {
            MainViewModel.Instance.PagePath = NavigationHelper.USER_LIST;
        }

        /// <summary>
        /// Navigate to user create page
        /// </summary>
        private void CreateUser()
        {
            MainViewModel.Instance.PagePath = NavigationHelper.USER_CREATE;
        }

        /// <summary>
        /// Get roles
        /// </summary>
        private void GetRole()
        {
            User.Roles = new ObservableCollection<RoleModel>();
            var model = _roleService.GetAll();
            model.ForEach(x => User.Roles.Add(new RoleModel
            {
                Id = x.Id,
                Name = x.Name
            }));
        }

        /// <summary>
        /// Validate password inputs
        /// </summary>
        /// <returns></returns>
        private bool validatePassInput()
        {
            bool result = true;
            if (string.IsNullOrEmpty(User.OldPass))
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.OPASS_REQUIRE, Message.USER_TTL);
            }
            else if(string.IsNullOrEmpty(User.Password))
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.NPASS_REQUIRE, Message.USER_TTL);
            }
            else if(string.IsNullOrEmpty(User.ConfirmPass))
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.CPASS_REQUIRE, Message.USER_TTL);
            }
            else if (User.ConfirmPass != User.Password) 
            {
                result = false;
                MessageBoxHelper.validateMessageBox(Message.PASSWORD_NOT_MATCH, Message.USER_TTL);
            }
            return result;
        }

        /// <summary>
        /// Change password
        /// </summary>
        private void ChangedPass()
        {
            bool validated = validatePassInput();
            
            if (validated)
            {
                
                var model = _userService.Get(loginId);
                bool validPass = BCrypt.Net.BCrypt.Verify(User.OldPass, model.Password);
                if (validPass)
                {
                    ResponseModel responseModel = new ResponseModel();
                    UserViewModel userViewModel = new UserViewModel();
                    userViewModel.Id = model.Id;
                    userViewModel.Password = User.Password;
                    responseModel = _userService.ChangePass(userViewModel);
                    if (responseModel.MessageType == Message.SUCCESS)
                    {
                        MessageBoxHelper.showMessageBox(responseModel,Message.USER_TTL);
                        resetPassInput();
                    }
                    else
                    {
                        MessageBoxHelper.showMessageBox(responseModel, Message.USER_TTL);
                    }
                }
                else
                {
                    MessageBox.Show("Old password is incorrect.");
                }
            }
            
            
        }

        /// <summary>
        /// Retrieve user lists
        /// </summary>
        /// <param name="keyword"></param>
        private void GetAll(string keyword = "")
        {
            User.Users = new ObservableCollection<UserModel>();
            var model = _userService.GetAll(keyword);
            model.Users.ForEach(x => User.Users.Add(new UserModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Email = x.Email,
                SRole = x.sRole,
                Status = x.IsActive ? "Active" : "Inactive",
                Phone = x.PhoneNo,
                Address = x.Address,
                SDob = x.sDob,
            }));

        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        private void Delete(int id)
        {
            var confirmResult = MessageBoxHelper.confirmMessageBox(Message.DELETE_CONFIRM,"User");
            if (confirmResult == MessageBoxResult.Yes)
            {
                ResponseModel responseModel = _userService.Delete(id,loginId);
                if (responseModel.MessageType == Message.SUCCESS)
                {
                    MessageBoxHelper.showMessageBox(responseModel, "User");
                    GetAll();
                }
                else
                {
                    MessageBoxHelper.showMessageBox(responseModel, "User");
                }
                
            }
            
            
        }

        /// <summary>
        /// Search user
        /// </summary>
        /// <param name="keywords"></param>
        private void Search(string keywords)
        {
            GetAll(keywords);
        }

        /// <summary>
        /// Validate user inputs
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        private bool ValidateInput()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(User.FirstName))
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.FNAME_REQUIRE,Message.USER_TTL);
            }
            else if (String.IsNullOrEmpty(User.LastName))
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.LNAME_REQUIRE, Message.USER_TTL);
            }
            else if (String.IsNullOrEmpty(User.Email))
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.EMAIL_REQUIRE, Message.USER_TTL);
            }
            else if (String.IsNullOrEmpty(User.Phone))
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.PHONE_REQUIRE, Message.USER_TTL);
            }
            else if (String.IsNullOrEmpty(User.Address))
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.ADDRESS_REQUIRE, Message.USER_TTL);
            }
            else if (User.Role <= 0)
            {
                isValid = false;
                MessageBoxHelper.validateMessageBox(Message.ROLE_REQUIRE, Message.USER_TTL);
            }
            else if (User.Id == null || User.Id <= 0)
            {
                if (String.IsNullOrEmpty(User.Password))
                {
                    isValid = false;
                    MessageBoxHelper.validateMessageBox(Message.PASS_REQUIRE, Message.USER_TTL);
                }
                else if (String.IsNullOrEmpty(User.ConfirmPass))
                {
                    isValid = false;
                    MessageBoxHelper.validateMessageBox(Message.CPASS_REQUIRE, Message.USER_TTL);
                }
                else if (User.Password != User.ConfirmPass)
                {
                    isValid = false;
                    MessageBoxHelper.validateMessageBox(Message.PASSWORD_NOT_MATCH, Message.USER_TTL);
                }
            }
            return isValid;
        }

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id"></param>
        private void Get(int id)
        {
            try
            {
                if (User != null)
                {
                    var model = _userService.Get(id);
                    User.Id = model.Id;
                    User.Email = model.Email;
                    User.FirstName = model.FirstName;
                    User.LastName = model.LastName;
                    User.Phone = model.PhoneNo;
                    User.Address = model.Address;
                    User.SDob = model.sDob;
                    User.Role = model.Role;
                    User.IsActive = model.IsActive;
                    User.Password = model.Password;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Clear password inputs
        /// </summary>
        private void resetPassInput()
        {
            User.OldPass = "";
            User.Password = "";
            User.ConfirmPass = "";
        }

        /// <summary>
        /// Save user data
        /// </summary>
        private void Save()
        {
            try
            {
                if (User != null)
                {
                    ResponseModel responseModel = new ResponseModel();
                    bool isValid = ValidateInput();
                    if(isValid)
                    {
                        UserViewModel userModel = new UserViewModel();
                        userModel.FirstName = User.FirstName;
                        userModel.LastName = User.LastName;
                        userModel.Email = User.Email;
                        userModel.Password = User.Password;
                        userModel.Role = User.Role;
                        userModel.Address = User.Address;
                        userModel.PhoneNo = User.Phone;
                        userModel.IsActive = User.IsActive;
                        if (!String.IsNullOrEmpty(User.SDob))
                        {
                            userModel.Dob = Convert.ToDateTime(User.SDob.ToString());
                        }
                        if(User.Id > 0)
                        {
                            userModel.Id = User.Id;
                            userModel.UpdateUserId = loginId.ToString();
                            responseModel = _userService.Update(userModel);
                        }
                        else
                        {
                            userModel.CreatedUserId = loginId.ToString();
                            responseModel = _userService.Save(userModel);
                        }

                        if (responseModel.MessageType == Message.SUCCESS)
                        {
                            MessageBoxHelper.showMessageBox(responseModel, "User");
                            MainViewModel.Instance.PagePath = NavigationHelper.USER_LIST;
                        }
                        else
                        {
                            MessageBoxHelper.showMessageBox(responseModel,"User");
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
