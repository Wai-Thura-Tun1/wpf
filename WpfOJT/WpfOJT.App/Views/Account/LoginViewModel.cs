using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfOJT.App.Helpers;
using WpfOJT.App.ViewModels;
using WpfOJT.DAO.Helpers;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;
using WpfOJT.Services.Services;

namespace WpfOJT.App.Views.Account
{
    /// <summary>
    /// Define the <see cref="LoginViewModel"/>
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Define the loginModel
        /// </summary>
        public LoginModel loginModel { get; set; }

        /// <summary>
        /// Define the authService
        /// </summary>
        public IAuthService authService { get; set; }

        /// <summary>
        /// Define the LoginCommand
        /// </summary>
        public GalaSoft.MvvmLight.Command.RelayCommand<ICloseable> LoginCommand { get; set; }

        /// <summary>
        /// Define the LogoutCommand
        /// </summary>
        public GalaSoft.MvvmLight.Command.RelayCommand<ICloseable> LogoutCommand { get; set; }
        public LoginViewModel()
        {
           loginModel = new LoginModel();
            authService = new AuthService();
            this.LoginCommand = new GalaSoft.MvvmLight.Command.RelayCommand<ICloseable>(this.Login);
            this.LogoutCommand = new GalaSoft.MvvmLight.Command.RelayCommand<ICloseable>(this.Logout);
        }

        /// <summary>
        /// Validate user inputs
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool ValidateInputs(LoginModel model)
        {
            bool validated = true;
            if (model.Email == String.Empty)
            {
                MessageBoxHelper.validateMessageBox(Message.EMAIL_REQUIRE, Message.USER_TTL);
            }
            else if (model.Password == String.Empty)
            {
                MessageBoxHelper.validateMessageBox(Message.PASS_REQUIRE, Message.USER_TTL);
            }
            return validated;
        }

        /// <summary>
        /// user login
        /// </summary>
        /// <param name="window"></param>
        private void Login(ICloseable window)
        {
            try
            {
                if (loginModel != null)
                {
                    bool validated = ValidateInputs(loginModel);
                    LogInViewModel logInViewModel = new LogInViewModel();
                    logInViewModel.Email = loginModel.Email;
                    logInViewModel.Password = loginModel.Password;
                    if (validated)
                    {
                        ResponseModel responseModel = authService.Authenticate(logInViewModel);
                        if (responseModel.MessageType == Message.SUCCESS)
                        {
                            Application.Current.Properties.Add("UserId", responseModel.Id);
                            new WpfOJT.App.MainWindow().Show();
                            if (window != null)
                            {
                                window.Close();
                            }
                        }
                        else
                        {
                            MessageBoxHelper.showMessageBox(responseModel,"Login");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        /// <summary>
        /// user logout
        /// </summary>
        /// <param name="window"></param>
        private void Logout(ICloseable window)
        {
            try
            {
                Application.Current.Properties.Remove("UserId");
                new WpfOJT.App.Views.Account.Login().Show();
                if (window != null)
                {
                    window.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


    }
}
