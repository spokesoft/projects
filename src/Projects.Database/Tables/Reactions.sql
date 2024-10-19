CREATE TABLE [App].[Reactions]
(
    [Id] BIGINT NOT NULL PRIMARY KEY,

    [CreatedAt] DATETIME2(7) NOT NULL,
    [UpdatedAt] DATETIME2(7) NOT NULL,
    [DeletedAt] DATETIME2(7) NULL,

    [CommentId] BIGINT NOT NULL,
    [CreatedById] BIGINT NOT NULL,
    [UpdatedById] BIGINT NOT NULL,
    [DeletedById] BIGINT NULL,

    FOREIGN KEY (CommentId) REFERENCES App.Comments(Id),
    FOREIGN KEY (CreatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (UpdatedById) REFERENCES Auth.Users(Id),
    FOREIGN KEY (DeletedById) REFERENCES Auth.Users(Id)
)
