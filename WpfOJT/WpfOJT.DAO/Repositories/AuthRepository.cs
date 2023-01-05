using WpfOJT.DAO.Helpers;
using WpfOJT.DAO.IRepositories;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.DAO.Repositories
{
    /// <summary>
    /// Define the <see cref="AuthRepository"/>
    /// </summary>
    public class AuthRepository : IAuthRepository
    {
        /// <summary>
        /// Authenticate user
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The <see cref="ResponseModel"/>.</returns>
        public ResponseModel Authenticate(LogInViewModel model)
        {
            ResponseModel responseModel = new ResponseModel();
            using(var _context = new BulltetinboardContext())
            {
                var query = _context.Users.FirstOrDefault(x => x.Email == model.Email && x.IsDeleted == false);
                if (query != null)
                {
                    bool verifyPass = BCrypt.Net.BCrypt.Verify(model.Password,query.Password);
                    if (verifyPass)
                    {
                        if(!query.IsActive)
                        {
                            responseModel.MessageType = Message.FAIL;
                            responseModel.Message = Message.ACCOUNT_NOT_ACTIVE;
                        }
                        else
                        {
                            responseModel.Id = query.Id;
                            responseModel.MessageType = Message.SUCCESS;
                            responseModel.Message = "";
                        }
                    }
                    else
                    {
                        responseModel.MessageType = Message.FAIL;
                        responseModel.Message = Message.PASSWORD_NOT_MATCH;
                    }
                }
                else
                {
                    responseModel.MessageType = Message.FAIL;
                    responseModel.Message = Message.EMAIL_NOT_EXIST;
                }
            }
            return responseModel;
        }
    }
}
