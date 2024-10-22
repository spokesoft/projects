using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tix.Data.Models;

[Table("Tickets", Schema = "App")]
public partial class Ticket : TixEntity
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string Title { get; set; } = null!;

    [StringLength(255)]
    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? AssignedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public long ProjectId { get; set; }

    public long? AssignedToId { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public long? DeletedById { get; set; }

    public long? CompletedById { get; set; }

    [ForeignKey("AssignedToId")]
    [InverseProperty("TicketAssignedTos")]
    public virtual User? AssignedTo { get; set; }

    [InverseProperty("Ticket")]
    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    [ForeignKey("CompletedById")]
    [InverseProperty("TicketCompletedBies")]
    public virtual User? CompletedBy { get; set; }

    [ForeignKey("CreatedById")]
    [InverseProperty("TicketCreatedBies")]
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("DeletedById")]
    [InverseProperty("TicketDeletedBies")]
    public virtual User? DeletedBy { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("Tickets")]
    public virtual Project Project { get; set; } = null!;

    [ForeignKey("UpdatedById")]
    [InverseProperty("TicketUpdatedBies")]
    public virtual User UpdatedBy { get; set; } = null!;
}
