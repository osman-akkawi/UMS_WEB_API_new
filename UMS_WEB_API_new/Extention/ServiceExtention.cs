using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Faculties;
using UMS_BLL.Services.Majors;
using UMS_BLL.Services.Users;

namespace UMS_WEB_API_new.Extention
{
    public static class ServiceExtention
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IMajorService, MajorService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IFacultyService, FacultyService>();
            service.AddScoped<IAuthService, AuthService>();


            return service;

        }
    }
}
