using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Payment : Common.Common
{
    public int PaymentId { get; set; }

    public int? PaymentMethodId { get; set; }

    public int? OrderId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? PaymentDate { get; set; } = DateTime.Now;

    [JsonIgnore]
    public virtual Order? Order { get; set; }

    [JsonIgnore]
    public virtual PaymentMethod? PaymentMethod { get; set; }
}
