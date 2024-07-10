using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class BlogCategory : Common.Common
{
    public int BlogCategoryId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;
    [JsonIgnore]

    public virtual ICollection<BlogCategoryMap> BlogCategoryMaps { get; set; } = new List<BlogCategoryMap>();
}
