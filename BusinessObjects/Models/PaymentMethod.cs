using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class PaymentMethod : Common.Common
{
    public int PaymentMethodId { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
