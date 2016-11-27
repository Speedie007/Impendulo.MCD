CREATE TABLE [dbo].[CompanyAddresses] (
    [CompanyID] INT NOT NULL,
    [AddressID] INT NOT NULL,
    CONSTRAINT [PK_CompanyAddresses_1] PRIMARY KEY CLUSTERED ([CompanyID] ASC, [AddressID] ASC),
    CONSTRAINT [FK_CompanyAddresses_Addresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID]),
    CONSTRAINT [FK_CompanyAddresses_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID])
);





