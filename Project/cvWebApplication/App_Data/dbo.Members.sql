CREATE TABLE [dbo].[Members] (
    [MemberId]      INT  NOT NULL,
    [Name]          TEXT NULL,
    [BirthDate]     DATE NOT NULL,
    [JoinDate]      DATE NOT NULL,
    [MainRole]      TEXT NULL,
    [SecondaryRole] TEXT NULL,
    PRIMARY KEY CLUSTERED ([MemberId] ASC)
);

