using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;
using OfficeOpenXml;

namespace WpfOJT.DAO.IRepositories
{
    /// <summary>
    /// Define the <see cref="IPostRepository"/>
    /// </summary>
    public interface IPostRepository
    {
        /// <summary>
        /// Retrieve posts from database
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="PostListViewModel"/>.</returns>
        PostListViewModel GetAll(int userId, string keywords);

        /// <summary>
        /// Get post by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="PostViewModel"/>.</returns>
        PostViewModel Get(int id);

        /// <summary>
        /// Save post into database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Save(Post model);

        /// <summary>
        /// Update post 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Update(Post model);

        /// <summary>
        /// Delete post
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionId"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Delete(int id,int actionId);

        /// <summary>
        /// Upload data from excel file
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="id"></param>
        /// <param name="sheet"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Upload(int rows,int id,ExcelWorksheet sheet);
    }
}
