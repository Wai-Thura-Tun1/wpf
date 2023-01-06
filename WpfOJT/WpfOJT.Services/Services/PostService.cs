using AutoMapper;
using OfficeOpenXml;
using WpfOJT.DAO.IRepositories;
using WpfOJT.DAO.Repositories;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.Helpers;
using WpfOJT.Services.IServices;

namespace WpfOJT.Services.Services
{
    /// <summary>
    /// Define the <see cref="PostService"/>
    /// </summary>
    public class PostService : IPostService
    {
        /// <summary>
        /// Define the _postRepository
        /// </summary>
        private IPostRepository _postRepository;

        /// <summary>
        /// Define the _mapper
        /// </summary>
        private IMapper _mapper; 

        public PostService() {
            _postRepository = new PostRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            _mapper = config.CreateMapper();
        }

        /// <summary>
        /// Delete post
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionId"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Delete(int id,int actionId)
        {
            return _postRepository.Delete(id,actionId);
        }

        /// <summary>
        /// Get post by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="PostViewModel"/>.</returns>
        public PostViewModel Get(int id)
        {
            return _postRepository.Get(id);
        }

        /// <summary>
        /// Retrieve posts from database
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="PostListViewModel"/>.</returns>
        public PostListViewModel GetAll(int userId, string keywords)
        {
            return _postRepository.GetAll(userId, keywords);
        }

        /// <summary>
        /// Save post into database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Save(PostViewModel model)
        {
            return _postRepository.Save(_mapper.Map<Post>(model));
        }

        /// <summary>
        /// Update post 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Update(PostViewModel model)
        {
            return _postRepository.Update(_mapper.Map<Post>(model));
        }

        /// <summary>
        /// Upload data from excel file
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <param name="sheet"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Upload(int rows,int id,ExcelWorksheet sheet)
        {
            return _postRepository.Upload(rows,id,sheet);
        }
    }
}
