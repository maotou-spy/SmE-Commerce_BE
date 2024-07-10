using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class DiscountProduct
{
    public int DiscountProductId { get; set; }

    public int? DiscountId { get; set; }

    public int? ProductId { get; set; }

    [JsonIgnore]
    public virtual Discount? Discount { get; set; }

    [JsonIgnore]
    public virtual Product? Product { get; set; }
}
