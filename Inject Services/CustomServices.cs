using ProfessionalGYM.Interfaces.IUser;
using ProfessionalGYM.Services.UserService;

namespace ProfessionalGYM.Inject_Services
{
    public static class CustomServices
    {
        public static void AddCustomServices(this IServiceCollection services)
        {

            services.AddScoped<IUser,UserServices>();

           
        }
    }
}
