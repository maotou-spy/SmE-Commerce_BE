using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class OrderPoint : Common.Common
{
    public int OrderPointId { get; set; }

    public int? OrderId { get; set; }

    public int? PointId { get; set; }

    [JsonIgnore]
    public virtual Order? Order { get; set; }

    [JsonIgnore]
    public virtual Point? Point { get; set; }
}
