using OfficeOpenXml;
using WpfOJT.DAO.Helpers;
using WpfOJT.DAO.IRepositories;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.Repositories
{
    /// <summary>
    /// Define the <see cref="PostRepository"/>
    /// </summary>
    public class PostRepository : IPostRepository
    {
        /// <summary>
        /// Define the _context
        /// </summary>
        private BulltetinboardContext _context;

        public PostRepository()
        {
            _context = new BulltetinboardContext();
        }

        /// <summary>
        /// Delete post
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionId"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Delete(int id,int actionId)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var currentPost = _context.Posts.FirstOrDefault(x => x.Id == id);
                currentPost.IsDeleted = true;
                currentPost.DeletedDate = DateTime.Now;
                currentPost.DeletedUserId = actionId.ToString();
                _context.Posts.Update(currentPost);
                _context.SaveChanges();
                responseModel.Message = Message.DELETE_SUCCESS;
                responseModel.MessageType = Message.SUCCESS;
            }
            catch(Exception ex)
            {
                responseModel.Message = Message.DELETE_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }

        /// <summary>
        /// Get post by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="PostViewModel"/>.</returns>
        public PostViewModel Get(int id)
        {
            var query = (from data in _context.Posts
                         where data.Id == id
                         select new PostViewModel
                         {
                             Id = data.Id,
                             Title = data.Title,
                             Description = data.Description,
                             IsPublished = data.IsPublished,
                         }).FirstOrDefault();
            return query;
        }

        /// <summary>
        /// Retrieve posts from database
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="PostListViewModel"/>.</returns>
        public PostListViewModel GetAll(int userId, string keywords)
        {
            PostListViewModel postListViewModel = new PostListViewModel();
            var loginUser = _context.Users.FirstOrDefault(x => x.Id == userId);
            var query = (from data in _context.Posts
                         join user in _context.Users on data.CreatedUserId equals user.Id.ToString()
                         where data.IsDeleted == false
                         orderby data.CreatedDate descending
                         select new PostViewModel
                         {
                             Id = data.Id,
                             Title = data.Title,
                             Description = data.Description,
                             IsPublished = data.IsPublished,
                             Status = data.IsPublished ? "Published" : "Unpublished",
                             CreatedDate = data.CreatedDate,
                             sCreatedDate = data.CreatedDate.ToString("dd/MM/yyyy"),
                             CreatedUserId = data.CreatedUserId,
                             CreatedUserName = user.FirstName + " " + user.LastName,
                         });
            if (loginUser != null && loginUser.Role == 2)
            {
                query = query.Where(x => x.CreatedUserId == loginUser.Id.ToString());
            }

            if(!String.IsNullOrEmpty(keywords))
            {
                string searchString = keywords.ToLower();
                query = query.Where(x =>
                x.Title.ToLower().Contains(searchString) ||
                x.Description.ToLower().Contains(searchString)
                );
            }
            postListViewModel.TotalPosts = query.Count();
            postListViewModel.Posts = query.ToList();
            return postListViewModel;
        }

        /// <summary>
        /// Save post into database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Save(Post model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                model.CreatedDate = DateTime.Now;
                _context.Posts.Add(model);
                _context.SaveChanges();
                responseModel.Message = Message.SAVE_SUCCESS;
                responseModel.MessageType = Message.SUCCESS;
            }
            catch(Exception ex)
            {
                responseModel.Message = Message.SAVE_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }

        /// <summary>
        /// Update post 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Update(Post model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var currentPost = _context.Posts.FirstOrDefault(x => x.Id == model.Id);
                currentPost.Id = model.Id;
                currentPost.Title = model.Title;
                currentPost.Description = model.Description;
                currentPost.IsPublished = model.IsPublished;
                currentPost.UpdatedDate = DateTime.Now;
                currentPost.UpdatedUserId = model.UpdatedUserId;
                _context.Posts.Update(currentPost);
                _context.SaveChanges();
                responseModel.Message = Message.UPDATE_SUCCESS;
                responseModel.MessageType = Message.SUCCESS;
            }
            catch(Exception ex)
            {
                responseModel.Message = Message.UPDATE_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }

        /// <summary>
        /// Upload data from excel file
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <param name="id"></param>
        /// <param name="sheet"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Upload(int rows,int id, ExcelWorksheet sheet)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                for(int row = 2; row <= rows; row++)
                {
                    Post postModel = new Post();
                    postModel.Title = sheet.Cells[row, 1].Value.ToString();
                    postModel.Description = sheet.Cells[row, 2].Value.ToString();
                    postModel.IsPublished = sheet.Cells[row, 3].Value.ToString() == "Published" ? true : false;
                    postModel.CreatedDate = DateTime.Now;
                    postModel.CreatedUserId = id.ToString();
                    _context.Posts.Add(postModel);
                    _context.SaveChanges();
                }
                responseModel.MessageType = Message.SUCCESS;
                responseModel.Message = Message.UPLOAD_SUCCESS;
            }
            catch(Exception ex)
            {
                responseModel.MessageType = Message.FAIL;
                responseModel.Message = Message.UPLOAD_FAIL;
            }
            return responseModel;
        }
    }
}
