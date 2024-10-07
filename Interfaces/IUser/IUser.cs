using ProfessionalGYM.DataTransferModel.GymUser;
using ProfessionalGYM.DataTransferModel.ResponseVM;

namespace ProfessionalGYM.Interfaces.IUser
{
    public interface IUser
    {
        Task<ResponseVM> CreateUser(UserVM user);
    }
}
