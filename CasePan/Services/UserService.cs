using CasePan.Data;
using CasePan.Dto;
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

        public async Task<ResponseModel<List<UserModel>>> DeleteUser(Guid userId)
        {
            ResponseModel<List<UserModel>> response = new ResponseModel<List<UserModel>>();

            try
            {
                var user = await _context.Users
                    .FirstOrDefaultAsync(userDb => userDb.Id == userId);

                if (user == null)
                {
                    response.Message = "No records found";
                    return response;
                }

                _context.Remove(user);
                await _context.SaveChangesAsync();

                response.Data = await _context.Users.ToListAsync();
                response.Message = "Record deleted successfully";

                return response;
            } catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseModel<List<UserModel>>> EditUser(EditUserDto editUser)
        {
            ResponseModel<List<UserModel>> response = new ResponseModel<List<UserModel>>();
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(userDb => userDb.Id == editUser.Id);

                if (user == null)
                {
                    response.Message = "No records found";
                    return response;
                }

                user.Name = editUser.Name;
                user.Password = editUser.Password;

                _context.Update(user);
                await _context.SaveChangesAsync();

                response.Data = await _context.Users.ToListAsync();
                response.Message = "Record edited successfully";
                return response;


            } catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
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

        public async Task<ResponseModel<UserModel>> GetUserById(Guid userId)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(userDb => userDb.Id == userId);
                if(user == null)
                {
                    response.Message = "No records found";
                    return response;
                }

                response.Data = user;
                response.Message = "Record found!";
                return response;

            } catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseModel<List<UserModel>>> SaveUser(CreateUserDTO userDTO)
        {
            ResponseModel<List<UserModel>> response = new ResponseModel<List<UserModel>>();

            try
            {
                var user = new UserModel()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Password = userDTO.Password
                };

                _context.Add(user);
                await _context.SaveChangesAsync();

                response.Data = await _context.Users.ToListAsync();
                response.Message = "User successfully registered!";

                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

    }
}
