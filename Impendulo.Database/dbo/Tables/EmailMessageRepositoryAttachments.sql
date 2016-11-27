CREATE TABLE [dbo].[EmailMessageRepositoryAttachments] (
    [ImageID]                  INT NOT NULL,
    [EmailMessageRepositoryID] INT NOT NULL,
    CONSTRAINT [PK_EmailMessageRepositoryAttachments_1] PRIMARY KEY CLUSTERED ([ImageID] ASC, [EmailMessageRepositoryID] ASC),
    CONSTRAINT [FK_EmailMessageRepositoryAttachments_EmailMessageRepository1] FOREIGN KEY ([EmailMessageRepositoryID]) REFERENCES [dbo].[EmailMessageRepository] ([EmailMessageRepositoryID]),
    CONSTRAINT [FK_EmailMessageRepositoryAttachments_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID])
);





