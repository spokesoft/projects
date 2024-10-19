using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projects.Data.Models;

[Table("UserClaims", Schema = "Auth")]
public partial class UserClaim
{
    [Key]
    public int Id { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public long UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserClaims")]
    public virtual User User { get; set; } = null!;
}
