using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Category : Common.Common
{
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string? CategoryImage { get; set; }

    [JsonIgnore]
    public string? CategoryImageHash { get; set; }

    public string? Description { get; set; }

    [JsonIgnore]
    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
}
