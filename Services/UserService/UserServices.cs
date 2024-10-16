using ProfessionalGYM.AppDb;
using ProfessionalGYM.DataTransferModel.GymUser;
using ProfessionalGYM.DataTransferModel.ResponseVM;
using ProfessionalGYM.Interfaces.IUser;
using ProfessionalGYM.Models.Entity.UserEntity;
using static ProfessionalGYM.DataTransferModel.ResponseVM.ResponseVM;

namespace ProfessionalGYM.Services.UserService
{
    public class UserServices : IUser
    {
        private readonly GymDB _db;
        private readonly IConfiguration config;
        public UserServices(GymDB db)
        {
            _db = db;

        }
       public async  Task<ResponseVM> CreateUser(UserVM user)
        {
            ResponseVM response = ResponseVM.Instance;

            var existingUser = _db.UsersDetails
                   .FirstOrDefault(x => x.UserName == user.UserName && x.UserEmail == user.UserEmail);

            if (existingUser != null)
            {
                response.responseCode = ResponseCode.BadRequest;
                response.errorMessage = "Username Already Exists";
                return response;
            }
            else
            {


                // Map UserVM to User entity
                var UserVM = new User
                {
                    UserEmail = user.UserEmail,
                    UserName = user.UserName,
                    Password = user.Password,
                    UserType = user.UserType,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Gender = user.Gender,
                    PhoneNumber = user.PhoneNumber,
                    DateOfBirth = user.DateOfBirth,
                    Address = user.Address,
                    ProfileImageUrl = user.ProfileImageUrl
                };

                _db.UsersDetails.Add(UserVM);
                await _db.SaveChangesAsync();


                response.responseCode = ResponseCode.Success;
                response.responseMessage = "User created successfully";
                return response;
            }

        }
    }

}
