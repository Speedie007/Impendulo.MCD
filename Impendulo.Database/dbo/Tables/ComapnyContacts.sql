CREATE TABLE [dbo].[ComapnyContacts] (
    [IndividualID] INT NOT NULL,
    [CompanyID]    INT NOT NULL,
    CONSTRAINT [PK_ComapnyContacts_1] PRIMARY KEY CLUSTERED ([IndividualID] ASC, [CompanyID] ASC),
    CONSTRAINT [FK_ComapnyContacts_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_ComapnyContacts_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID])
);

