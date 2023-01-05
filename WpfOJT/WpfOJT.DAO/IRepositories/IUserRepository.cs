using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.IRepositories
{
    /// <summary>
    /// Define the <see cref="IUserRepository"/>
    /// </summary>
    public interface IUserRepository
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
        ResponseModel Save(User model);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deletedUser"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Delete(int id,int deletedUser);


        /// <summary>
        /// Update user data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Update(User model);


        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel ChangePass(User Model);
    }
}
