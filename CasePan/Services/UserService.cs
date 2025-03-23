using CasePan.Data;
using CasePan.Models;
using Microsoft.EntityFrameworkCore;

namespace CasePan.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context) {
            _context = context; 
        }

        public async Task<ResponseModel<List<UserModel>>> GetAllUsers()
        {
            ResponseModel<List<UserModel>> respose = new ResponseModel<List<UserModel>>();
            try
            {
                var users = await _context.Users.ToListAsync();

                respose.Data = users;

                respose.Message = "All users have been listed";
                return respose;

            } catch (Exception ex)
            {
                respose.Message = ex.Message;
                respose.Status = false;
                return respose;
            }

        }

        public Task<ResponseModel<UserModel>> GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
