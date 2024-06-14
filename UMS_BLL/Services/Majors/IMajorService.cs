using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.DTO.Major;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;
using UMS_DAL.Models;

namespace UMS_BLL.Services.Majors
{
    public interface IMajorService : IGenericService<GetAllMajorsDTO>
    {

       ApiResponse<IEnumerable<GetMajorByFacultyIdDTO>> GetMajorByFacultyId(int id);

    }
}
