using OfficeOpenXml;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.Services.IServices
{
    /// <summary>
    /// Define the <see cref="IPostService"/>
    /// </summary>
    public interface IPostService
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
        ResponseModel Save(PostViewModel model);

        /// <summary>
        /// Update post 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Update(PostViewModel model);

        /// <summary>
        /// Delete post
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionId"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Delete(int id, int actionId);

        /// <summary>
        /// Upload data from excel file
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <param name="sheet"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        ResponseModel Upload(int rows,int id, ExcelWorksheet sheet);
    }
}
