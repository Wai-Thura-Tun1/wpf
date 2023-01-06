using AutoMapper;
using WpfOJT.DAO.IRepositories;
using WpfOJT.DAO.Repositories;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;
using WpfOJT.Services.Helpers;
using WpfOJT.Services.IServices;

namespace WpfOJT.Services.Services
{
    /// <summary>
    /// Define the <see cref="UserService"/>
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Define the _userRepository
        /// </summary>
        private IUserRepository _userRepository;

        /// <summary>
        /// Define the _mapper
        /// </summary>
        private IMapper _mapper;
        public UserService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfiles());
            });
            _mapper = config.CreateMapper();
            _userRepository = new UserRepository();
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel ChangePassword(UserViewModel model)
        {
            return _userRepository.ChangePassword(_mapper.Map<User>(model));
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="deletedUser"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Delete(int id,int deleteUser)
        {
            return _userRepository.Delete(id,deleteUser);
        }

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The <see cref="UserViewModel"/>.</returns>
        public UserViewModel Get(int id)
        { 
            return _userRepository.Get(id);
        }

        /// <summary>
        /// Retrieve user lists
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns>The <see cref="UserListViewModel"/>.</returns>
        public UserListViewModel GetAll(string keywords)
        {
            return _userRepository.GetAll(keywords);
        }

        /// <summary>
        /// Register user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Save(UserViewModel model)
        {
            return _userRepository.Save(_mapper.Map<User>(model));
        }

        /// <summary>
        /// Update user data
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Update(UserViewModel model)
        {
            return _userRepository.Update(_mapper.Map<User>(model));
        }
    }
}
