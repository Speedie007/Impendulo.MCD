CREATE TABLE [dbo].[EnquiryEmailCorrespondence] (
    [EmailMessageRepositoryID] INT NOT NULL,
    [EnquiryID]                INT NOT NULL,
    CONSTRAINT [PK_EnquiryEmailCorrespondence] PRIMARY KEY CLUSTERED ([EmailMessageRepositoryID] ASC, [EnquiryID] ASC),
    CONSTRAINT [FK_EnquiryEmailCorrespondence_EmailMessageRepository] FOREIGN KEY ([EmailMessageRepositoryID]) REFERENCES [dbo].[EmailMessageRepository] ([EmailMessageRepositoryID]),
    CONSTRAINT [FK_EnquiryEmailCorrespondence_Enquiry] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID])
);

