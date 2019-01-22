CREATE TABLE [dbo].[Users] (
    [MemberId]      INT  NOT NULL,
    [Username]      TEXT NOT NULL,
    [Password]		VARCHAR(16) NOT NULL ,
    PRIMARY KEY		CLUSTERED ([MemberId] ASC)
);

