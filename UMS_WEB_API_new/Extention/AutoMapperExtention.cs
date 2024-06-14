using UMS_BLL.Mapping;

namespace UMS_WEB_API_new.Extention
{
    public static class AutoMapperExtention
    {

        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;
        }

    }
}
