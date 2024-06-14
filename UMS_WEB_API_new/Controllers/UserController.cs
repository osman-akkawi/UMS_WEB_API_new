using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Major;
using UMS_BLL.DTO.User;
using UMS_BLL.Services._GenericService;
using UMS_BLL.Services.Users;

namespace UMS_WEB_API_new.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : GenericController<UserDto>
    {
        public readonly IUserService _service;
        public UserController(IUserService service) : base(service)
        {
            _service = service;
        }

    }
}
