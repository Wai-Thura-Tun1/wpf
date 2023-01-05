using WpfOJT.DAO.IRepositories;
using WpfOJT.DAO.Repositories;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.IServices;

namespace WpfOJT.Services.Services
{
    /// <summary>
    /// Define the <see cref="RoleService"/>
    /// </summary>
    public class RoleService : IRoleService
    {
        /// <summary>
        /// Define the _roleRepository
        /// </summary>
        private IRoleRepository _roleRepository;

        public RoleService()
        {
            _roleRepository = new RoleRepository();
        }

        /// <summary>
        /// Get roles
        /// </summary>
        /// <returns>The <see cref="List{RoleModel}"/>.</returns>
        public List<RoleModel> GetAll()
        {
            return _roleRepository.GetAll();
        }
    }
}
