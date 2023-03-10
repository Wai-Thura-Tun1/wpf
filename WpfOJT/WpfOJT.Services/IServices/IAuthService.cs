using WpfOJT.Entities.DTO;

namespace WpfOJT.Services.IServices
{
    /// <summary>
    /// Define the <see cref="IAuthService"/>
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Authenticate(LogInViewModel model);
    }
}
