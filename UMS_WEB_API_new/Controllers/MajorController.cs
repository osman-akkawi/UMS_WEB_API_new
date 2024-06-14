using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.DTO.Major;
using UMS_BLL.Rapping;
using UMS_BLL.Services.Majors;

namespace UMS_WEB_API_new.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class MajorController : GenericController<GetAllMajorsDTO>
    {
        public readonly IMajorService _service;

        public MajorController(IMajorService service): base (service)
        {
            _service = service;
        }
       
        
        [HttpGet("GetMajorsByFacultyId")]
        public ApiResponse<IEnumerable<GetMajorByFacultyIdDTO>> GetMajorsByFacultyId(int id)
        {
            return _service.GetMajorByFacultyId(id);
        }
    }

}
