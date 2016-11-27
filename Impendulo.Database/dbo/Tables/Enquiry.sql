CREATE TABLE [dbo].[Enquiry] (
    [EnquiryID]                   INT  IDENTITY (1, 1) NOT NULL,
    [EnquiryDate]                 DATE CONSTRAINT [DF_Enquiry_EnquiryDate] DEFAULT (getdate()) NOT NULL,
    [InitialConsultationComplete] BIT  CONSTRAINT [DF_Enquiry_InitialConsultationComplete] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Enquiry] PRIMARY KEY CLUSTERED ([EnquiryID] ASC)
);









