CREATE TABLE [dbo].[CurriculumEnquiries] (
    [CurriculumEnquiryID]                       INT      IDENTITY (1, 1) NOT NULL,
    [EnquiryID]                                 INT      NOT NULL,
    [CurriculumID]                              INT      NOT NULL,
    [EnquiryStatusID]                           INT      NOT NULL,
    [LastUpdated]                               DATETIME CONSTRAINT [DF_CurriculumEnquiries_LastUpdated] DEFAULT (getdate()) NOT NULL,
    [EnrollmentQuanity]                         INT      CONSTRAINT [DF_CurriculumEnquiries_EnrollmentQuanity] DEFAULT ((1)) NOT NULL,
    [InitialCurriculumEnquiryDocumentationSent] BIT      CONSTRAINT [DF_CurriculumEnquiries_InitialCurriculumEnquiryDocumentationSent] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_CurriculumEnquiries] PRIMARY KEY CLUSTERED ([CurriculumEnquiryID] ASC),
    CONSTRAINT [FK_CurriculumEnquiries_Curriculums] FOREIGN KEY ([CurriculumID]) REFERENCES [dbo].[Curriculums] ([CurriculumID]),
    CONSTRAINT [FK_CurriculumEnquiries_Enquiry] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID]),
    CONSTRAINT [FK_CurriculumEnquiries_LookupEnquiryStatuses] FOREIGN KEY ([EnquiryStatusID]) REFERENCES [dbo].[LookupEnquiryStatuses] ([EnquiryStatusID])
);



