using System;
using System.Collections.Generic;

namespace UMS_WEB_API_new.Models;

public partial class Faculty
{
    public int FacultyId { get; set; }

    public string FacultyName { get; set; } = null!;

    public string DeanName { get; set; } = null!;

    public virtual ICollection<Major> Majors { get; set; } = new List<Major>();
}
