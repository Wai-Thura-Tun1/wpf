using System.Windows;
using WpfOJT.DAO.Helpers;
using WpfOJT.Entities.DTO;

namespace WpfOJT.App.Helpers
{
    /// <summary>
    /// Define the <see cref="MessageBoxHelper"/>
    /// </summary>
    public class MessageBoxHelper
    {
        /// <summary>
        /// Show message box using response
        /// </summary>
        /// <param name="responseModel"></param>
        /// <param name="caption"></param>
        public static void showMessageBox(ResponseModel responseModel,string caption)
        {
            if (responseModel.MessageType == Message.SUCCESS)
            {
                MessageBox.Show(responseModel.Message,caption,MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else if (responseModel.MessageType == Message.FAIL)
            {
                MessageBox.Show(responseModel.Message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (responseModel.MessageType == Message.EXIST)
            {
                MessageBox.Show(responseModel.Message, caption, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// Show confirm message box 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static MessageBoxResult confirmMessageBox(string message,string caption)
        {
            var result = MessageBox.Show(message,caption,MessageBoxButton.YesNo,MessageBoxImage.Question);
            return result;
        }

        /// <summary>
        /// Show validate message box
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"></param>
        public static void validateMessageBox(string message,string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
