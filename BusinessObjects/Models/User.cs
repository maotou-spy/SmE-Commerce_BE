using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class User : Common.Common
{
    public int UserId { get; set; }

    public int RoleId { get; set; }

    [EmailAddress]
    public string? Email { get; set; }

    public required string FullName { get; set; }

    [Phone]
    public required string Phone { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    [JsonIgnore]
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    [JsonIgnore]
    public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();

    [JsonIgnore]
    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    [JsonIgnore]
    public virtual ICollection<DiscountCode> DiscountCodes { get; set; } = new List<DiscountCode>();

    [JsonIgnore]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [JsonIgnore]
    public virtual ICollection<Point> Points { get; set; } = new List<Point>();
    
    [JsonIgnore]
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    [JsonIgnore]
    public virtual Role Role { get; set; } = null!;
}
