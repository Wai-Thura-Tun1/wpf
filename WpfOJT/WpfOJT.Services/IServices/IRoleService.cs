using WpfOJT.Entities.DTO;

namespace WpfOJT.Services.IServices
{
    /// <summary>
    /// Define the <see cref="IRoleService"/>
    /// </summary>
    public interface IRoleService
    {
        /// <summary>
        /// Get roles
        /// </summary>
        /// <returns>The <see cref="List{RoleModel}"/>.</returns>
        List<RoleModel> GetAll();
    }
}
