using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.User;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;

namespace UMS_BLL.Services.Users
{
    public interface IUserService : IGenericService<UserDto>
    {
       ApiResponse<bool> Login(string username, string password);
    }
}
