using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Login;
using UMS_BLL.Rapping;
using UMS_DAL.Repositories.Users;

namespace UMS_BLL.Services.Auth
{
    public class AuthService : IAuthService
    {
        public readonly IUserRepository _userRepository;
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ApiResponse<bool> Login(LoginRequestDto loginRequestDto)
        {
            var user = _userRepository.GetUserByUsername(loginRequestDto.Username);
            if (user == null)
            {
                throw new Exception("Not Found");
            }
            if (user.Password != loginRequestDto.Password)
            {
                throw new Exception("Not Found");

            }
            return new ApiResponse<bool>(true);
        
           }
        }
    }

