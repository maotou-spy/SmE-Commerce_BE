using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class DiscountCode : Common.Common
{
    public int CodeId { get; set; }

    public int DiscountId { get; set; }

    public int? UserId { get; set; }

    public DateTime FromDate { get; set; } = DateTime.Now;

    public DateTime ToDate { get; set; }

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual Discount Discount { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [JsonIgnore]
    public virtual User? User { get; set; }
}
