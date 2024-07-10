using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusinessObjects.Models;

public partial class Discount : Common.Common
{
    public int DiscountId { get; set; }

    [Required]
    public string DiscountName { get; set; } = null!;

    [Required]
    public bool IsPercentage { get; set; } = true;

    public decimal? DiscountPercentage { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? MinimumOrderAmount { get; set; }

    public decimal? MaximumDiscount { get; set; }

    public DateTime? FromDate { get; set; } = DateTime.Now;

    public DateTime? ToDate { get; set; }

    public string Status { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<DiscountCode> DiscountCodes { get; set; } = new List<DiscountCode>();

    [JsonIgnore]
    public virtual ICollection<DiscountProduct> DiscountProducts { get; set; } = new List<DiscountProduct>();
}
