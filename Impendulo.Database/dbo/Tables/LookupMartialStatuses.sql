CREATE TABLE [dbo].[LookupMartialStatuses] (
    [MartialStatusID] INT          IDENTITY (1, 1) NOT NULL,
    [MaritialStatus]  VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_LookupMartialStatuses] PRIMARY KEY CLUSTERED ([MartialStatusID] ASC)
);

