CREATE TABLE [dbo].[CurriculumEquirySelectedCourses] (
    [CurriculumEquirySelectedCourseID] INT IDENTITY (1, 1) NOT NULL,
    [CurriculumEnquiryID]              INT NOT NULL,
    [CurriculumCourseID]               INT NOT NULL,
    [EnrollmentQuanity]                INT CONSTRAINT [DF_CurriculumEquiryCourses_EnrollmentQuanity] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_CurriculumEquiryCourses] PRIMARY KEY CLUSTERED ([CurriculumEquirySelectedCourseID] ASC),
    CONSTRAINT [FK_CurriculumEquiryCourses_CurriculumEnquiries] FOREIGN KEY ([CurriculumEnquiryID]) REFERENCES [dbo].[CurriculumEnquiries] ([CurriculumEnquiryID]),
    CONSTRAINT [FK_CurriculumEquirySelectedCourses_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
);

