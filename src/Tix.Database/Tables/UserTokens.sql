CREATE TABLE [Auth].[UserTokens]
(
    [UserId] BIGINT NOT NULL,
    [LoginProvider] NVARCHAR(450) NOT NULL,

    [Name] NVARCHAR(450) NOT NULL,
    [Value] NVARCHAR(MAX),

    PRIMARY KEY (UserId, LoginProvider, Name),
    FOREIGN KEY (UserId) REFERENCES Auth.Users(Id)
);