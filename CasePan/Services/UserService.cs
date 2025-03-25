using CasePan.Data;
using CasePan.Dto;
using CasePan.Models;
using CasePan.Validators;
using Microsoft.EntityFrameworkCore;

namespace CasePan.Service
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;

        // Constructor with dependency injection for database context
        public UserService(AppDbContext context) {
            _context = context; 
        }

        // Deletes a user by ID and returns the updated user list
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
            } 
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        // Edits an existing user after validating the input data
        public async Task<ResponseModel<UserModel>> EditUser(EditUserDto editUser)
        {
            ResponseModel<UserModel> response = new ResponseModel<UserModel>();
            var userValidator = new UserValidator();

            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(userDb => userDb.Id == editUser.Id);

                if (user == null)
                {
                    response.Message = "No records found";
                    return response;
                }

                // Validate user input
                userValidator.validatorName(editUser.Name);
                userValidator.validatorPassword(editUser.Password);

                user.Name = editUser.Name;
                user.Password = editUser.Password;

                _context.Update(user);
                await _context.SaveChangesAsync();

                response.Data = user;
                response.Message = "Record edited successfully";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        // Retrieves all users from the database
        public async Task<ResponseModel<List<UserModel>>> GetAllUsers()
        {
            ResponseModel<List<UserModel>> response = new ResponseModel<List<UserModel>>();
            try
            {
                var users = await _context.Users.ToListAsync();

                response.Data = users;
                response.Message = "All users have been listed";
                return response;
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        // Retrieves a user by ID
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
            } 
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Status = false;
                return response;
            }
        }

        // Saves a new user after validating input data
        public async Task<ResponseModel<List<UserModel>>> SaveUser(CreateUserDTO userDTO)
        {
            ResponseModel<List<UserModel>> response = new ResponseModel<List<UserModel>>();
            var userValidator = new UserValidator();

            try
            {
                // Validate user input
                userValidator.validatorName(userDTO.Name);  
                userValidator.validatorPassword(userDTO.Password);
                userValidator.validatorEmail(userDTO.Email);

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