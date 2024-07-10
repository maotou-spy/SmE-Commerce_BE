using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class ProductImage : Common.Common
{
    public int ImageId { get; set; }

    public int? ProductId { get; set; }

    public string Url { get; set; } = null!;

    [JsonIgnore]
    public string? ImageHash { get; set; }

    public string? AltText { get; set; }

    [JsonIgnore]
    public virtual Product? Product { get; set; }
}
