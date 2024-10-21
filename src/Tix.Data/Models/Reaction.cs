using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Projects.Data.Models;

[Table("Reactions", Schema = "App")]
public partial class Reaction
{
    [Key]
    public long Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public long CommentId { get; set; }

    public long CreatedById { get; set; }

    public long UpdatedById { get; set; }

    public long? DeletedById { get; set; }

    [ForeignKey("CommentId")]
    [InverseProperty("Reactions")]
    public virtual Comment Comment { get; set; } = null!;

    [ForeignKey("CreatedById")]
    [InverseProperty("ReactionCreatedBies")]
    public virtual User CreatedBy { get; set; } = null!;

    [ForeignKey("DeletedById")]
    [InverseProperty("ReactionDeletedBies")]
    public virtual User? DeletedBy { get; set; }

    [ForeignKey("UpdatedById")]
    [InverseProperty("ReactionUpdatedBies")]
    public virtual User UpdatedBy { get; set; } = null!;
}
