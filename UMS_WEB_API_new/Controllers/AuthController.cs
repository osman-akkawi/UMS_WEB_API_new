using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.DTO.Login;
using UMS_BLL.Rapping;
using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Faculties;

namespace UMS_WEB_API_new.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        public readonly IAuthService _authService;

        public AuthController(IAuthService service) 
        {
            _authService = service;
        }

        [HttpPost("Login")]
        public ApiResponse<bool> Login(LoginRequestDto loginRequestDto)
        {
            return _authService.Login(loginRequestDto);

        }



    }
}
