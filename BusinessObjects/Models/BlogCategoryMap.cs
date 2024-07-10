using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class BlogCategoryMap : Common.Common
{
    public int BlogCategoryMapId { get; set; }

    public int? BlogId { get; set; }

    public int? BlogCategoryId { get; set; }

    [JsonIgnore]
    public virtual Blog? Blog { get; set; }

    [JsonIgnore]
    public virtual BlogCategory? BlogCategory { get; set; }
}
