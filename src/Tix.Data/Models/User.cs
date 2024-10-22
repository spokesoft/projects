using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Tix.Data.Models;

[Table("Users", Schema = "Auth")]
public partial class User
{
    [Key]
    public long Id { get; set; }

    [StringLength(256)]
    public string? UserName { get; set; }

    [StringLength(256)]
    public string? NormalizedUserName { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(256)]
    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    [InverseProperty("CreatedBy")]
    public virtual ICollection<Attachment> AttachmentCreatedBies { get; set; } = new List<Attachment>();

    [InverseProperty("DeletedBy")]
    public virtual ICollection<Attachment> AttachmentDeletedBies { get; set; } = new List<Attachment>();

    [InverseProperty("UpdatedBy")]
    public virtual ICollection<Attachment> AttachmentUpdatedBies { get; set; } = new List<Attachment>();

    [InverseProperty("CreatedBy")]
    public virtual ICollection<Comment> CommentCreatedBies { get; set; } = new List<Comment>();

    [InverseProperty("DeletedBy")]
    public virtual ICollection<Comment> CommentDeletedBies { get; set; } = new List<Comment>();

    [InverseProperty("UpdatedBy")]
    public virtual ICollection<Comment> CommentUpdatedBies { get; set; } = new List<Comment>();

    [InverseProperty("CreatedBy")]
    public virtual ICollection<Project> ProjectCreatedBies { get; set; } = new List<Project>();

    [InverseProperty("DeletedBy")]
    public virtual ICollection<Project> ProjectDeletedBies { get; set; } = new List<Project>();

    [InverseProperty("UpdatedBy")]
    public virtual ICollection<Project> ProjectUpdatedBies { get; set; } = new List<Project>();

    [InverseProperty("CreatedBy")]
    public virtual ICollection<Reaction> ReactionCreatedBies { get; set; } = new List<Reaction>();

    [InverseProperty("DeletedBy")]
    public virtual ICollection<Reaction> ReactionDeletedBies { get; set; } = new List<Reaction>();

    [InverseProperty("UpdatedBy")]
    public virtual ICollection<Reaction> ReactionUpdatedBies { get; set; } = new List<Reaction>();

    [InverseProperty("AssignedTo")]
    public virtual ICollection<Ticket> TicketAssignedTos { get; set; } = new List<Ticket>();

    [InverseProperty("CompletedBy")]
    public virtual ICollection<Ticket> TicketCompletedBies { get; set; } = new List<Ticket>();

    [InverseProperty("CreatedBy")]
    public virtual ICollection<Ticket> TicketCreatedBies { get; set; } = new List<Ticket>();

    [InverseProperty("DeletedBy")]
    public virtual ICollection<Ticket> TicketDeletedBies { get; set; } = new List<Ticket>();

    [InverseProperty("UpdatedBy")]
    public virtual ICollection<Ticket> TicketUpdatedBies { get; set; } = new List<Ticket>();

    [InverseProperty("User")]
    public virtual ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();

    [InverseProperty("User")]
    public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();

    [InverseProperty("User")]
    public virtual ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();

    [ForeignKey("UserId")]
    [InverseProperty("Users")]
    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
