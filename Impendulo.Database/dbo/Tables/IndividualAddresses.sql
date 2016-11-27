CREATE TABLE [dbo].[IndividualAddresses] (
    [AddressID]    INT NOT NULL,
    [IndividualID] INT NOT NULL,
    CONSTRAINT [PK_IndividualAddresses_1] PRIMARY KEY CLUSTERED ([AddressID] ASC, [IndividualID] ASC),
    CONSTRAINT [FK_IndividualAddresses_Addresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([AddressID]),
    CONSTRAINT [FK_IndividualAddresses_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID])
);



