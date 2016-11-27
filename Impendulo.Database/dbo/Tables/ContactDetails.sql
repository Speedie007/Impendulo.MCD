CREATE TABLE [dbo].[ContactDetails] (
    [ContactDetailID]    INT           IDENTITY (1, 1) NOT NULL,
    [ContactDetailValue] VARCHAR (100) CONSTRAINT [DF_ContactDetails_ContactDetail] DEFAULT ('Unknown') NOT NULL,
    [ContactTypeID]      INT           NOT NULL,
    CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED ([ContactDetailID] ASC),
    CONSTRAINT [FK_ContactDetails_LookupContactTypes] FOREIGN KEY ([ContactTypeID]) REFERENCES [dbo].[LookupContactTypes] ([ContactTypeID])
);



