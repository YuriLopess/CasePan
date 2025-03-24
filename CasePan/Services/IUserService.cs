using CasePan.Data;
using CasePan.Dto;
using CasePan.Models;

namespace CasePan.Service
{
    public interface IUserService    
    {
        Task<ResponseModel<List<UserModel>>> GetAllUsers();

        Task<ResponseModel<UserModel>> GetUserById(Guid userId);

        Task<ResponseModel<List<UserModel>>> SaveUser(CreateUserDTO saveUser);

        Task<ResponseModel<List<UserModel>>> EditUser(EditUserDto editUser);

        Task<ResponseModel<List<UserModel>>> DeleteUser(Guid userId);

    }
}
