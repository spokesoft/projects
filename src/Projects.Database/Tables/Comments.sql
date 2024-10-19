CREATE TABLE [App].[Comments]
(
  [Id] BIGINT NOT NULL PRIMARY KEY,

  [Content] NVARCHAR(255) NULL,
  
  [CreatedAt] DATETIME2(7) NOT NULL,
  [UpdatedAt] DATETIME2(7) NOT NULL,
  [DeletedAt] DATETIME2(7) NULL,

  [ProjectId] BIGINT NULL,
  [TicketId] BIGINT NULL,
  [CreatedById] BIGINT NOT NULL,
  [UpdatedById] BIGINT NOT NULL,
  [DeletedById] BIGINT NULL,
  
  FOREIGN KEY (CreatedById) REFERENCES Auth.Users(Id),
  FOREIGN KEY (UpdatedById) REFERENCES Auth.Users(Id),
  FOREIGN KEY (DeletedById) REFERENCES Auth.Users(Id)
)
