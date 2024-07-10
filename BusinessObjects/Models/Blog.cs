using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Blog : Common.Common
{
    public int BlogId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public int? AuthorId { get; set; }

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual User? Author { get; set; }

    [JsonIgnore]
    public virtual ICollection<BlogCategoryMap> BlogCategoryMaps { get; set; } = new List<BlogCategoryMap>();
}
