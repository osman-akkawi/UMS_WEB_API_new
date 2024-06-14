using Microsoft.EntityFrameworkCore;
using UMS_DAL.Models;

namespace UMS_WEB_API_new.Extention
{
    public static class DbExtention

    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<UmsContext>(options =>
                                options.UseSqlServer(ConnectionString)
                                );
            return service;
        }
    }
}
