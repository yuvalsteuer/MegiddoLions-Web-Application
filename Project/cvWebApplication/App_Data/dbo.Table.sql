CREATE TABLE [dbo].[Members]
(
	[MemberId] INT NOT NULL PRIMARY KEY, 
    [Name] TEXT NULL,
	[BirthDate] DATE NOT NULL,
    [JoinDate] DATE NULL,
	[MainRole] TEXT NULL,
	[SecondaryRole] TEXT NULL
)
