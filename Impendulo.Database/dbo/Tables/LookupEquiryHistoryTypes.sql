CREATE TABLE [dbo].[LookupEquiryHistoryTypes] (
    [LookupEquiyHistoryTypeID]   INT          IDENTITY (1, 1) NOT NULL,
    [LookupEquiyHistoryTypeName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_LookupEquiyHistoryTypes] PRIMARY KEY CLUSTERED ([LookupEquiyHistoryTypeID] ASC)
);

