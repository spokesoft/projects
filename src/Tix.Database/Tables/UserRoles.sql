CREATE TABLE [Auth].[UserRoles]
(
    [UserId] BIGINT NOT NULL,
    [RoleId] BIGINT NOT NULL,

    PRIMARY KEY (UserId, RoleId),
    FOREIGN KEY (UserId) REFERENCES Auth.Users(Id),
    FOREIGN KEY (RoleId) REFERENCES Auth.Roles(Id)
);