using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.Services.IServices
{
    /// <summary>
    /// Define the <see cref="IUserService"/>
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieve user lists
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="UserListViewModel"/>.</returns>
        UserListViewModel GetAll(string keywords);

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="UserViewModel"/>.</returns>
        UserViewModel Get(int id);

        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Save(UserViewModel model);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deletedUser"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Delete(int id,int deleteUser);

        /// <summary>
        /// Update user data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Update(UserViewModel model);

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel ChangePassword(UserViewModel model);
    }
}
