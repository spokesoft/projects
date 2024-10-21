using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projects.Data.Models;

[Table("Attachments", Schema = "App")]
public partial class Attachment
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long? CommentId { get; set; }

    public long? ProjectId { get; set; }

    public long? TicketId { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public long? DeletedById { get; set; }

    [ForeignKey("CommentId")]
    [InverseProperty("Attachments")]
    public virtual Comment? Comment { get; set; }

    [ForeignKey("CreatedById")]
    [InverseProperty("AttachmentCreatedBies")]
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("DeletedById")]
    [InverseProperty("AttachmentDeletedBies")]
    public virtual User? DeletedBy { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("Attachments")]
    public virtual Project? Project { get; set; }

    [ForeignKey("TicketId")]
    [InverseProperty("Attachments")]
    public virtual Ticket? Ticket { get; set; }

    [ForeignKey("UpdatedById")]
    [InverseProperty("AttachmentUpdatedBies")]
    public virtual User UpdatedBy { get; set; } = null!;
}
