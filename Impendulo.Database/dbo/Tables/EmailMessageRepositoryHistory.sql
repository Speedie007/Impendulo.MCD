CREATE TABLE [dbo].[EmailMessageRepositoryHistory] (
    [EmailMessageRepositoryHistoryID]               INT      IDENTITY (1, 1) NOT NULL,
    [EmailMessageRepositoryID]                      INT      NOT NULL,
    [EmailMessageRepositoryHistoryTrancationTypeID] INT      NOT NULL,
    [DateTransactionCompleted]                      DATETIME CONSTRAINT [DF_EmailMessageRepositoryHistory_DateTransactionCompleted] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_EmailMessageRepositoryHistory] PRIMARY KEY CLUSTERED ([EmailMessageRepositoryHistoryID] ASC),
    CONSTRAINT [FK_EmailMessageRepositoryHistory_EmailMessageRepository] FOREIGN KEY ([EmailMessageRepositoryID]) REFERENCES [dbo].[EmailMessageRepository] ([EmailMessageRepositoryID]),
    CONSTRAINT [FK_EmailMessageRepositoryHistory_LookupEmailMessageRepositoryHistoryTrancationTypes] FOREIGN KEY ([EmailMessageRepositoryHistoryTrancationTypeID]) REFERENCES [dbo].[LookupEmailMessageRepositoryHistoryTrancationTypes] ([EmailMessageRepositoryHistoryTrancationTypeID])
);

