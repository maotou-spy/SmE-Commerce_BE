using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Order : Common.Common
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? AddressId { get; set; }

    /// <summary>
    /// Bill of Lading Id: "Mã vận đơn";
    /// </summary>
    public string? BOlid { get; set; }

    public bool? IsTa { get; set; }

    public decimal TotalAmount { get; set; }

    public int? CodeId { get; set; }

    /// <summary>
    /// Reason khi chuyển status (reject/cancel)
    /// </summary>
    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual Address? Address { get; set; }

    [JsonIgnore]
    public virtual DiscountCode? Code { get; set; }

    [JsonIgnore]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    [JsonIgnore]
    public virtual ICollection<OrderPoint> OrderPoints { get; set; } = new List<OrderPoint>();

    [JsonIgnore]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [JsonIgnore]
    public virtual User? User { get; set; }
}
