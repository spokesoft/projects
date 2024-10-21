using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projects.Data.Models;

[Table("Comments", Schema = "App")]
public partial class Comment
{
    [Key]
    public long Id { get; set; }

    [StringLength(255)]
    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long? ProjectId { get; set; }

    public long? TicketId { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public long? DeletedById { get; set; }

    [InverseProperty("Comment")]
    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    [ForeignKey("CreatedById")]
    [InverseProperty("CommentCreatedBies")]
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("DeletedById")]
    [InverseProperty("CommentDeletedBies")]
    public virtual User? DeletedBy { get; set; }

    [InverseProperty("Comment")]
    public virtual ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();

    [ForeignKey("UpdatedById")]
    [InverseProperty("CommentUpdatedBies")]
    public virtual User UpdatedBy { get; set; } = null!;
}
