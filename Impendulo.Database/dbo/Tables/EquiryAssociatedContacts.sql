CREATE TABLE [dbo].[EquiryAssociatedContacts] (
    [IndividualID] INT NOT NULL,
    [EnquiryID]    INT NOT NULL,
    CONSTRAINT [PK_EquiryAssociatedContacts] PRIMARY KEY CLUSTERED ([IndividualID] ASC, [EnquiryID] ASC),
    CONSTRAINT [FK_EquiryAssociatedContacts_Enquiry] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID]),
    CONSTRAINT [FK_EquiryAssociatedContacts_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID])
);

