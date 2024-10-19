CREATE TABLE [Auth].[UserClaims] 
(
    [Id] INT IDENTITY PRIMARY KEY,

    [ClaimType] NVARCHAR(MAX),
    [ClaimValue] NVARCHAR(MAX),

    [UserId] BIGINT NOT NULL,

    FOREIGN KEY (UserId) REFERENCES Auth.Users(Id)
);