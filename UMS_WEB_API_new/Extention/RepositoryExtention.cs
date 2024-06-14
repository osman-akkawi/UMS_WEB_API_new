using UMS_DAL.Repositories.Faculties;
using UMS_DAL.Repositories.Majors;
using UMS_DAL.Repositories.Users;

namespace UMS_WEB_API_new.Extention
{
    public static class RepositoryExtention
    {
        public static IServiceCollection AddRepositoty(this IServiceCollection service)
        {
            service.AddScoped<IFacultyRepository, FacultyRepository>();
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IMajorRepository, MajorRepository>();


            return service;
        }
    }
}
