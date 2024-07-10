using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Address : Common.Common
{
    public int AddressId { get; set; }

    public int? UserId { get; set; }

    [Required]
    public string ReceiverName { get; set; } = null!;

    [Phone]
    [Required]
    public string ReceiverPhone { get; set; } = null!;

    [Required]
    public string Street { get; set; } = null!;

    [Required]
    public string Ward { get; set; } = null!;

    [Required]
    public string District { get; set; } = null!;

    [Required]
    public string City { get; set; } = null!;

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [JsonIgnore]
    public virtual User? User { get; set; }
}
