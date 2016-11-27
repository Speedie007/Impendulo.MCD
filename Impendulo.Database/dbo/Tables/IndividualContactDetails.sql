CREATE TABLE [dbo].[IndividualContactDetails] (
    [IndividualID]    INT NOT NULL,
    [ContactDetailID] INT NOT NULL,
    CONSTRAINT [PK_IndividualContactDetails_1] PRIMARY KEY CLUSTERED ([IndividualID] ASC, [ContactDetailID] ASC),
    CONSTRAINT [FK_IndividualContactDetails_ContactDetails] FOREIGN KEY ([ContactDetailID]) REFERENCES [dbo].[ContactDetails] ([ContactDetailID]) ON DELETE CASCADE,
    CONSTRAINT [FK_IndividualContactDetails_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]) ON DELETE CASCADE
);





