using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UMS_BLL.DTO.Major;
using UMS_BLL.DTO.User;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;
using UMS_BLL.Services.Majors;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Majors;
using UMS_DAL.Repositories.Users;

namespace UMS_BLL.Services.Users
{
    public class UserService : GenericService<User, UserDto>, IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly IMapper _mapper;
        public UserService(IUserRepository userrepository, IMapper mapper) : base(userrepository, mapper)
        {
            _userRepository = userrepository;
            _mapper = mapper;
        }

        

        public ApiResponse<bool> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

    }

}
