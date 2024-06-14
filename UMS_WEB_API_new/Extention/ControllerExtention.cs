using UMS_WEB_API_new.Filters;

namespace UMS_WEB_API_new.Extention
{
    public static class ControllerExtention
    {
        public static IServiceCollection AddController(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });

            return services;
        }
    }
}
