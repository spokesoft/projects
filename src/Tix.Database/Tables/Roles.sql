CREATE TABLE [Auth].[Roles]
(
    [Id] BIGINT NOT NULL PRIMARY KEY,

    [Name] NVARCHAR(256),
    [NormalizedName] NVARCHAR(256),
    [ConcurrencyStamp] NVARCHAR(MAX)
);