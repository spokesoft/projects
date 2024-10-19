using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Projects.Data.Models;

namespace Projects.Data.Contexts;

public partial class ProjectsContext : DbContext
{
    public ProjectsContext(DbContextOptions<ProjectsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Reaction> Reactions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleClaim> RoleClaims { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07880D35A4");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Comment).WithMany(p => p.Attachments).HasConstraintName("FK__Attachmen__Comme__3587F3E0");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.AttachmentCreatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Attachmen__Creat__339FAB6E");

            entity.HasOne(d => d.DeletedBy).WithMany(p => p.AttachmentDeletedBies).HasConstraintName("FK__Attachmen__Delet__32AB8735");

            entity.HasOne(d => d.Project).WithMany(p => p.Attachments).HasConstraintName("FK__Attachmen__Proje__37703C52");

            entity.HasOne(d => d.Ticket).WithMany(p => p.Attachments).HasConstraintName("FK__Attachmen__Ticke__367C1819");

            entity.HasOne(d => d.UpdatedBy).WithMany(p => p.AttachmentUpdatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Attachmen__Updat__3493CFA7");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07A9EE8801");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.CommentCreatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comments__Create__395884C4");

            entity.HasOne(d => d.DeletedBy).WithMany(p => p.CommentDeletedBies).HasConstraintName("FK__Comments__Delete__3A4CA8FD");

            entity.HasOne(d => d.UpdatedBy).WithMany(p => p.CommentUpdatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Comments__Update__3864608B");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC070E76DD27");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.ProjectCreatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Projects__Create__0E6E26BF");

            entity.HasOne(d => d.DeletedBy).WithMany(p => p.ProjectDeletedBies).HasConstraintName("FK__Projects__Delete__0F624AF8");

            entity.HasOne(d => d.UpdatedBy).WithMany(p => p.ProjectUpdatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Projects__Update__0D7A0286");
        });

        modelBuilder.Entity<Reaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07542C9688");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Comment).WithMany(p => p.Reactions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reactions__Comme__3B40CD36");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.ReactionCreatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reactions__Creat__3E1D39E1");

            entity.HasOne(d => d.DeletedBy).WithMany(p => p.ReactionDeletedBies).HasConstraintName("FK__Reactions__Delet__3C34F16F");

            entity.HasOne(d => d.UpdatedBy).WithMany(p => p.ReactionUpdatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reactions__Updat__3D2915A8");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC0798585F13");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RoleClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07867A55DF");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleClaims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RoleClaim__RoleI__44CA3770");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC072B8F5322");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AssignedTo).WithMany(p => p.TicketAssignedTos).HasConstraintName("FK__Tickets__Assigne__3F115E1A");

            entity.HasOne(d => d.CompletedBy).WithMany(p => p.TicketCompletedBies).HasConstraintName("FK__Tickets__Complet__40F9A68C");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.TicketCreatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tickets__Created__40058253");

            entity.HasOne(d => d.DeletedBy).WithMany(p => p.TicketDeletedBies).HasConstraintName("FK__Tickets__Deleted__42E1EEFE");

            entity.HasOne(d => d.Project).WithMany(p => p.Tickets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tickets__Project__43D61337");

            entity.HasOne(d => d.UpdatedBy).WithMany(p => p.TicketUpdatedBies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tickets__Updated__41EDCAC5");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC076BCC024D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoles__RoleI__1332DBDC"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__UserRoles__UserI__14270015"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__UserRole__AF2760AD1601C478");
                        j.ToTable("UserRoles", "Auth");
                    });
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07A7BDFD5F");

            entity.HasOne(d => d.User).WithMany(p => p.UserClaims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserClaim__UserI__45BE5BA9");
        });

        modelBuilder.Entity<UserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey }).HasName("PK__UserLogi__2B2C5B528793975A");

            entity.HasOne(d => d.User).WithMany(p => p.UserLogins)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserLogin__UserI__123EB7A3");
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name }).HasName("PK__UserToke__8CC498411138ED00");

            entity.HasOne(d => d.User).WithMany(p => p.UserTokens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserToken__UserI__151B244E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
