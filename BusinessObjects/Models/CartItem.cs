using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class CartItem : Common.Common
{
    public int CartItemId { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    [Required]
    public int Quantity { get; set; } = 0;

    [JsonIgnore]
    public virtual Product? Product { get; set; }

    [JsonIgnore]

    public virtual User? User { get; set; }
}
