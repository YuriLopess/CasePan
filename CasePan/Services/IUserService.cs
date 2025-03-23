using CasePan.Models;

namespace CasePan.Service
{
    public interface IUserService    
    {
        Task<ResponseModel<List<UserModel>>> GetAllUsers();
        Task<ResponseModel<UserModel>> GetUserById(Guid userId);

    }
}
