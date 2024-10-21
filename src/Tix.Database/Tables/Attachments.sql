CREATE TABLE [App].[Attachments]
(
    [Id] BIGINT NOT NULL PRIMARY KEY,

    [Name] NVARCHAR(50) NOT NULL,

    [CreatedAt] DATETIME2(7) DEFAULT GETDATE(),
    [UpdatedAt] DATETIME2(7) DEFAULT GETDATE(),
    [DeletedAt] DATETIME2(7) NULL,

    [CommentId] BIGINT NULL,
    [ProjectId] BIGINT NULL,
    [TicketId] BIGINT NULL,
    [CreatedById] BIGINT NOT NULL,
    [UpdatedById] BIGINT NOT NULL,
    [DeletedById] BIGINT NULL,

    FOREIGN KEY (CommentId) REFERENCES App.Comments(Id),
    FOREIGN KEY (ProjectId) REFERENCES App.Projects(Id),
    FOREIGN KEY (TicketId) REFERENCES App.Tickets(Id),
    FOREIGN KEY (CreatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (UpdatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (DeletedById) REFERENCES Auth.Users(Id)
)
