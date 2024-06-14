using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UMS_BLL.DTO;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.DTO.Major;
using UMS_BLL.DTO.User;
using UMS_DAL.Models;

namespace UMS_BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        CreateMap<Major, GetAllMajorsDTO>().ReverseMap();
        CreateMap<Major, GetMajorByFacultyIdDTO>().ReverseMap();
            CreateMap<Faculty, FacultyDTO>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

        }
    }
}
