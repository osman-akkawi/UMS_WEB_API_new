using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;

namespace UMS_BLL.Services.Faculties
{
    public interface IFacultyService : IGenericService<FacultyDTO>
    {
       ApiResponse<FacultyDTO> GetFacultyByName(string name);
     
    }
}
