using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.DTO.Faculty
{
    public class FacultyDTO
    {
        public int FacultyId { get; set; }

        public string FacultyName { get; set; } = null!;

        public string DeanName { get; set; } = null!;
    }
}
