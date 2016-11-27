CREATE TABLE [dbo].[LookupContactTypes] (
    [ContactTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [ContactType]   VARCHAR (50) CONSTRAINT [DF_LookupContactTypes_ContactType] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_LookupContactTypes] PRIMARY KEY CLUSTERED ([ContactTypeID] ASC)
);

