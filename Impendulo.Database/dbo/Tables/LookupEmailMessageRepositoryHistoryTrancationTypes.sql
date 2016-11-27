CREATE TABLE [dbo].[LookupEmailMessageRepositoryHistoryTrancationTypes] (
    [EmailMessageRepositoryHistoryTrancationTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [EmailMessageRepositoryHistoryTrancationType]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_LookupEmailMessageRepositoryHistoryTrancationTypes] PRIMARY KEY CLUSTERED ([EmailMessageRepositoryHistoryTrancationTypeID] ASC)
);

