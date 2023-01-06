using WpfOJT.DAO.Helpers;
using WpfOJT.DAO.IRepositories;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.Repositories
{
    /// <summary>
    /// Define the <see cref="UserRepository"/>
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Define the _context
        /// </summary>
        private BulltetinboardContext _context;
        public UserRepository()
        {
            _context = new BulltetinboardContext();
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel ChangePassword(User model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var pModel = _context.Users.FirstOrDefault(x => x.Id == model.Id);
                pModel.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                pModel.UpdatedDate = DateTime.Now;
                pModel.UpdatedUserId = model.Id.ToString();

                _context.Users.Update(pModel);
                _context.SaveChanges();
                responseModel.Message = Message.PASS_SUCCESS;
                responseModel.MessageType = Message.SUCCESS;
            }
            catch (Exception ex)
            {
                responseModel.Message = Message.PASS_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deletedUser"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Delete(int id,int deleteUser)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var deletedUser = _context.Users.FirstOrDefault(u => u.Id == id);
                deletedUser.IsDeleted = true;
                deletedUser.DeletedDate = DateTime.Now;
                deletedUser.DeletedUserId = deleteUser.ToString();

                _context.Users.Update(deletedUser);
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
        /// Get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="UserViewModel"/>.</returns>
        public UserViewModel Get(int id)
        {
            var query = (from data in _context.Users
                         where data.Id == id
                         select new UserViewModel
                         {
                             Id = data.Id,
                             FirstName = data.FirstName,
                             LastName = data.LastName,
                             Email = data.Email,
                             PhoneNo = data.PhoneNo,
                             Address = data.Address,
                             Role = data.Role,
                             Dob = data.Dob,
                             sDob = data.Dob != null ? data.Dob.Value.ToString("MM/dd/yyyy") : "",
                             Password = data.Password,
                             IsActive = data.IsActive,
                         }).FirstOrDefault();
            return query;
        }

        /// <summary>
        /// Retrieve user lists
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="UserListViewModel"/>.</returns>
        public UserListViewModel GetAll(string keywords)
        {
            UserListViewModel model = new UserListViewModel();

            var query = (from data in _context.Users
                         join user in _context.Users on data.CreatedUserId equals Convert.ToString(user.Id)
                         where data.IsDeleted == false
                         orderby data.CreatedDate descending
                         select new UserViewModel
                         {
                             Id = data.Id,
                             FirstName = data.FirstName,
                             LastName = data.LastName,
                             FullName = data.FirstName + " " + data.LastName,
                             Email = data.Email,
                             sRole = data.Role == 1 ? "Admin" : "User",
                             PhoneNo = data.PhoneNo,
                             Address = data.Address,
                             Dob = data.Dob,
                             sDob = data.Dob != null ? data.Dob.Value.ToString("dd/MM/yyyy") : "",
                             IsActive = data.IsActive,
                             CreatedDate = data.CreatedDate,
                             sCreatedDate = data.CreatedDate.ToString("dd/MM/yyyy"),
                             CreatedUserId = data.CreatedUserId,
                             CreatedUserName = user.FirstName + " " + user.LastName
                         });
            if (!String.IsNullOrEmpty(keywords))
            {
                var searchString = keywords.ToLower();
                query = query.Where(x =>
                x.FullName.ToLower().Contains(searchString) ||
                x.Email.ToLower().Contains(searchString) ||
                x.sRole.ToLower().Contains(searchString) ||
                x.CreatedUserName.ToLower().Contains(searchString));
            }

            model.TotalUsers = query.Count();
            model.Users = query.ToList();
            return model;

        }

        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Save(User model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var exitUser = _context.Users.FirstOrDefault(x => x.Email == model.Email);
                if (exitUser == null)
                {
                    model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);
                    model.CreatedDate = DateTime.Now;
                    _context.Add(model);
                    _context.SaveChanges();
                    responseModel.Message = Message.SAVE_SUCCESS;
                    responseModel.MessageType = Message.SUCCESS;
                }
                else
                {
                    responseModel.Message = Message.EMAIL_EXIST;
                    responseModel.MessageType = Message.EXIST;
                }
            }
            catch(Exception ex)
            {
                responseModel.Message = Message.SAVE_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }

        /// <summary>
        /// Update user data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Update(User model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                var currentUser = _context.Users.FirstOrDefault(x => x.Id == model.Id);

                var emailExist = _context.Users.FirstOrDefault(x => x.Id != model.Id && x.Email == model.Email);
                if (emailExist == null)
                {
                    currentUser.FirstName = model.FirstName;
                    currentUser.LastName = model.LastName;
                    currentUser.Email = model.Email;
                    currentUser.PhoneNo = model.PhoneNo;
                    currentUser.Address = model.Address;
                    currentUser.Role = model.Role;
                    currentUser.Dob = model.Dob;
                    currentUser.IsActive = model.IsActive;
                    currentUser.UpdatedDate = DateTime.Now;
                    currentUser.UpdatedUserId = model.UpdatedUserId;
                    _context.Users.Update(currentUser);
                    _context.SaveChanges();

                    responseModel.Message = Message.UPDATE_SUCCESS;
                    responseModel.MessageType = Message.SUCCESS;
                }
                else
                {
                    responseModel.Message = Message.EMAIL_EXIST;
                    responseModel.MessageType = Message.EXIST;
                }
            }
            catch(Exception ex)
            {
                responseModel.Message = Message.UPDATE_FAIL;
                responseModel.MessageType = Message.FAIL;
            }
            return responseModel;
        }
    }
}
