using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.IRepositories
{
    /// <summary>
    /// Define the <see cref="IRoleRepository"/>
    /// </summary>
    public interface IRoleRepository
    {
        /// <summary>
        /// Get roles
        /// </summary>
        /// <returns>The <see cref="List{RoleModel}"/>.</returns>
        List<RoleModel> GetAll();
    }
}
