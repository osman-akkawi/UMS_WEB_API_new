using System;
using System.Collections.Generic;

namespace UMS_WEB_API_new.Models;

public partial class Gender
{
    public int GenderId { get; set; }

    public string Description { get; set; } = null!;
}
