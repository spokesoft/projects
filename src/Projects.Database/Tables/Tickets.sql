CREATE TABLE [App].[Tickets]
(
    [Id] BIGINT NOT NULL PRIMARY KEY,

    [Title] NVARCHAR(50) NOT NULL,
    [Content] NVARCHAR(255) NULL,

    [CreatedAt] DATETIME2(7) NOT NULL,
    [UpdatedAt] DATETIME2(7) NOT NULL,
    [DeletedAt] DATETIME2(7) NULL,
    [AssignedAt] DATETIME2(7) NULL,
    [CompletedAt] DATETIME2(7) NULL,

    [ProjectId] BIGINT NOT NULL,
    [AssignedToId] BIGINT NULL,
    [CreatedById] BIGINT NOT NULL,
    [UpdatedById] BIGINT NOT NULL,
    [DeletedById] BIGINT NULL,
    [CompletedById] BIGINT NULL,

    FOREIGN KEY (ProjectId) REFERENCES App.Projects(Id),
    FOREIGN KEY (AssignedToId) REFERENCES Auth.Users(Id),
    FOREIGN KEY (CreatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (UpdatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (DeletedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (CompletedById) REFERENCES Auth.Users(Id)
)
