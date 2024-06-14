using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Faculty;
using UMS_BLL.Rapping;
using UMS_BLL.Services._GenericService;
using UMS_BLL.Services.Faculties;
using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;

namespace UMS_WEB_API_new.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FacultiesController : GenericController<FacultyDTO>
    {
        public readonly IFacultyService _facultyService;

        public FacultiesController(IFacultyService service) : base(service)
        {
            _facultyService = service;
        }

        [HttpGet("GetFacultyByName")]
        public ApiResponse<FacultyDTO> GetFacultyByName(string name)
        {
           return _facultyService.GetFacultyByName(name);
            
        }

    }
}

