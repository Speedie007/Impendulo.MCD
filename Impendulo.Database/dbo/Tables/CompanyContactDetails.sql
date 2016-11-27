CREATE TABLE [dbo].[CompanyContactDetails] (
    [CompanyID]       INT NOT NULL,
    [ContactDetailID] INT NOT NULL,
    CONSTRAINT [PK_CompanyContactDetails] PRIMARY KEY CLUSTERED ([CompanyID] ASC, [ContactDetailID] ASC),
    CONSTRAINT [FK_CompanyContactDetails_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID])
);

