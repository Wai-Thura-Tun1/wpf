using WpfOJT.DAO.IRepositories;
using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.Repositories
{
    /// <summary>
    /// Define the <see cref="RoleRepository"/>
    /// </summary>
    public class RoleRepository:IRoleRepository
    {

        /// <summary>
        /// Get roles
        /// </summary>
        /// <returns>The <see cref="List{RoleModel}"/>.</returns>
        public List<RoleModel> GetAll()
        {
            List<RoleModel> roleList = new List<RoleModel>();

            RoleModel role = new RoleModel();
            role.Id = 1;
            role.Name = "Admin";
            roleList.Add(role);

            role = new RoleModel();
            role.Id = 2;
            role.Name = "User";
            roleList.Add(role);

            return roleList;
        }

    }
}
