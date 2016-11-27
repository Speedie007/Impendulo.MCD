CREATE TABLE [dbo].[CompanyEnquiry] (
    [EnquiryID] INT NOT NULL,
    [CompanyID] INT NOT NULL,
    CONSTRAINT [PK_CompanyEnquiry] PRIMARY KEY CLUSTERED ([EnquiryID] ASC, [CompanyID] ASC),
    CONSTRAINT [FK_CompanyEnquiry_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_CompanyEnquiry_Enquiry] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID])
);

