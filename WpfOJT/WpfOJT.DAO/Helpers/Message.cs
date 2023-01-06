using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOJT.DAO.Helpers
{
    /// <summary>
    /// Define the <see cref="Message"/>
    /// </summary>
    public class Message
    {
        #region Response
        public static string SAVE_SUCCESS = "Saved successfully.";
        public static string SAVE_FAIL = "Save failed";
        public static string UPDATE_SUCCESS = "Updated successfully.";
        public static string UPDATE_FAIL = "Update failed.";
        public static string ACCOUNT_NOT_ACTIVE = "Account is not activated.";
        public static string PASSWORD_NOT_MATCH = "Password does not match.";
        public static string EMAIL_EXIST = "Email already exists";
        public static string EMAIL_NOT_EXIST = "Email does not exist";
        public static string DELETE_CONFIRM = "Are you sure to delete.";
        public static string DELETE_SUCCESS = "Deleted successfully.";
        public static string DELETE_FAIL = "Delete failed";
        public static string UPLOAD_SUCCESS = "Uploaded successfully";
        public static string UPLOAD_FAIL = "Upload fail";
        #endregion 

        #region Validation
        public static string FNAME_REQUIRE = "First Name is required";
        public static string LNAME_REQUIRE = "Last Name is required";
        public static string EMAIL_REQUIRE = "Email is required";
        public static string PASS_REQUIRE = "Password is required";
        public static string CPASS_REQUIRE = "Confirm Password is required";
        public static string DOB_REQUIRE = "Date of Birth is required";
        public static string PHONE_REQUIRE = "Phone number is required";
        public static string ADDRESS_REQUIRE = "Address is required";
        public static string ROLE_REQUIRE = "Role is required";
        public static string OLD_WRONG = "Old password is incorrect.";
        public static string NPASS_REQUIRE = "New Password is required.";
        public static string OPASS_REQUIRE = "Old Password is required.";
        public static string PASS_SUCCESS = "Password has been changed successfully.";
        public static string PASS_FAIL = "Password could not be changed!";
        public static string TTL_REQUIRE = "Title is required.";
        public static string DESCRIP_REQUIRE = "Description is required.";
        #endregion 

        #region Caption
        public static string USER_TTL = "User";
        public static string POST_TTL = "POST";
        #endregion

        #region Type
        public static int SUCCESS = 1;
        public static int FAIL = 2;
        public static int EXIST = 3;
        #endregion
    }
}
