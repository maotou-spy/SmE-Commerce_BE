using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Models;

public partial class BankInfo : Common.Common
{
    public int BankInfoId { get; set; }

    [Required]
    public string BankCode { get; set; } = null!;

    [Required]
    public string BankName { get; set; } = null!;

    public string? BankLogoUrl { get; set; }

    [Required]
    public string AccountNumber { get; set; } = null!;

    [Required]
    public string AccountHolderName { get; set; } = null!;

    public string Status { get; set; } = null!;
}
