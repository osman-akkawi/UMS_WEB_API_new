using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.DTO.Major;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;
using UMS_DAL.Models;
using UMS_DAL.Repositories._GenericRepository;
using UMS_DAL.Repositories.Faculties;
using UMS_DAL.Repositories.Majors;

namespace UMS_BLL.Services.Faculties
{
    public class FacultyService : GenericService<Faculty, FacultyDTO>, IFacultyService
    {
        public readonly IFacultyRepository _facultyRepository;
        public readonly IMapper _mapper;
        public FacultyService(IFacultyRepository facultyRepository, IMapper mapper) : base(facultyRepository, mapper)
        {
            _facultyRepository = facultyRepository;
            _mapper = mapper;

        }

        public ApiResponse<FacultyDTO> GetFacultyByName(string name)
        {
            var response = new ApiResponse<FacultyDTO>();   
            var result = _facultyRepository.GetFacultyByName(name); 
            response.Data = _mapper.Map<FacultyDTO>(result);
            return response;
        }
    }
}
