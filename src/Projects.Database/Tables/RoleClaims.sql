CREATE TABLE [Auth].[RoleClaims] 
(
    [Id] INT IDENTITY PRIMARY KEY,

    [ClaimType] NVARCHAR(MAX),
    [ClaimValue] NVARCHAR(MAX),
    
    [RoleId] BIGINT NOT NULL,
    
    FOREIGN KEY (RoleId) REFERENCES Auth.Roles(Id)
);