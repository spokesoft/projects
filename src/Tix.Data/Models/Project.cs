using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tix.Data.Models;

[Table("Projects", Schema = "App")]
public partial class Project
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public long? DeletedById { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    [ForeignKey("CreatedById")]
    [InverseProperty("ProjectCreatedBies")]
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("DeletedById")]
    [InverseProperty("ProjectDeletedBies")]
    public virtual User? DeletedBy { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    [ForeignKey("UpdatedById")]
    [InverseProperty("ProjectUpdatedBies")]
    public virtual User UpdatedBy { get; set; } = null!;
}
