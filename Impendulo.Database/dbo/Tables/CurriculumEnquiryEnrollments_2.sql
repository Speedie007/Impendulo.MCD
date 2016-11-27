CREATE TABLE [dbo].[CurriculumEnquiryEnrollments] (
    [CurriculumEnquiryID] INT NOT NULL,
    [EnrollmentID]        INT NOT NULL,
    CONSTRAINT [PK_CurriculumEnquiryEnrollments_1] PRIMARY KEY CLUSTERED ([CurriculumEnquiryID] ASC, [EnrollmentID] ASC),
    CONSTRAINT [FK_CurriculumEnquiryEnrollments_CurriculumEnquiries] FOREIGN KEY ([CurriculumEnquiryID]) REFERENCES [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID]),
    CONSTRAINT [FK_CurriculumEnquiryEnrollments_Enrollments] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID])
);

