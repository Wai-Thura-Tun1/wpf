using WpfOJT.DAO.IRepositories;
using WpfOJT.DAO.Repositories;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;

namespace WpfOJT.Services.Services
{
    /// <summary>
    /// Define the <see cref="AuthService"/>
    /// </summary>
    public class AuthService : IAuthService
    {
        /// <summary>
        /// Define the _authRepository
        /// </summary>
        private IAuthRepository _authRepository;

        public AuthService()
        {
            _authRepository = new AuthRepository();
        }

        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Authenticate(LogInViewModel model)
        {
            ResponseModel responseModel = _authRepository.Authenticate(model);
            return responseModel;
        }
    }
}
