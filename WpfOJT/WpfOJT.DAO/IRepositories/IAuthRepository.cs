using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.IRepositories
{
    /// <summary>
    /// Define the <see cref="IAuthRepository"/>
    /// </summary>
    public interface IAuthRepository
    {
        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Authenticate(LogInViewModel model);
    }
}
