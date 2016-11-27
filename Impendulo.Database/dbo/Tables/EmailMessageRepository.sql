CREATE TABLE [dbo].[EmailMessageRepository] (
    [EmailMessageRepositoryID] INT           IDENTITY (1, 1) NOT NULL,
    [FromAddress]              VARCHAR (250) NOT NULL,
    [ToAddress]                VARCHAR (500) NOT NULL,
    [Subject]                  VARCHAR (250) NOT NULL,
    [Message]                  VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_EmailMessageRepository] PRIMARY KEY CLUSTERED ([EmailMessageRepositoryID] ASC)
);

