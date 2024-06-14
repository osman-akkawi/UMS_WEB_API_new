using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using UMS_BLL.DTO;
using UMS_BLL.DTO.Major;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;
using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;
using UMS_DAL.Repositories.Majors;

namespace UMS_BLL.Services.Majors
{
    public class MajorService : GenericService<Major, GetAllMajorsDTO>, IMajorService
    {
        public readonly IMajorRepository _majorRepository;
        public readonly  IMapper _mapper;

        public MajorService(IMajorRepository majorRepository, IMapper mapper) : base(majorRepository, mapper)
        {
            _majorRepository = majorRepository;
            _mapper = mapper;
        }

        public ApiResponse<IEnumerable<GetMajorByFacultyIdDTO>> GetMajorByFacultyId(int id)
        {
            var response = new ApiResponse<IEnumerable<GetMajorByFacultyIdDTO>>();
            var result = _majorRepository.GetMajorByFacultyId(id);
            response.Data = _mapper.Map<IEnumerable<GetMajorByFacultyIdDTO>>(result);
            return response;


        }

    }
   
}
