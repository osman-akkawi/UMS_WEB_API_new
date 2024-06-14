using System;
using System.Collections.Generic;

namespace UMS_WEB_API_new.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int FloorId { get; set; }

    public string RoomName { get; set; } = null!;

    public int RoomCapacity { get; set; }

    public virtual Floor Floor { get; set; } = null!;
}
