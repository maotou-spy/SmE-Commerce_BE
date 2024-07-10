using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Point : Common.Common
{
    public int PointId { get; set; }

    public int? UserId { get; set; }

    public int PointAmount { get; set; }

    public DateTime? ExpiryDate { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderPoint> OrderPoints { get; set; } = new List<OrderPoint>();

    [JsonIgnore]
    public virtual User? User { get; set; }
}
