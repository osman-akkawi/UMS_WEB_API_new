using System;
using System.Collections.Generic;

namespace UMS_WEB_API_new.Models;

public partial class Major
{
    public int MajorId { get; set; }

    public int FacultyId { get; set; }

    public string MajorName { get; set; } = null!;

    public virtual Faculty Faculty { get; set; } = null!;
}
