using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public int? ProductId { get; set; }

    public int? CategoryId { get; set; }

    [JsonIgnore]
    public virtual Category? Category { get; set; }

    [JsonIgnore]
    public virtual Product? Product { get; set; }
}
