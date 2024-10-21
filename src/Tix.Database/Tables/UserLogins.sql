CREATE TABLE [Auth].[UserLogins]
(
    [LoginProvider] NVARCHAR(450) NOT NULL,
    [ProviderKey] NVARCHAR(450) NOT NULL,

    [ProviderDisplayName] NVARCHAR(MAX),

    [UserId] BIGINT NOT NULL,

    PRIMARY KEY (LoginProvider, ProviderKey),
    FOREIGN KEY (UserId) REFERENCES Auth.Users(Id)
);