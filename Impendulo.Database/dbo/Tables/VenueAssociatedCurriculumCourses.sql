CREATE TABLE [dbo].[VenueAssociatedCurriculumCourses] (
    [VenueAssociatedCurriculumCourseID] INT IDENTITY (1, 1) NOT NULL,
    [VenueID]                           INT NOT NULL,
    [CurriculumCourseID]                INT NOT NULL,
    CONSTRAINT [PK_VenueAssociatedCurriculumCourses] PRIMARY KEY CLUSTERED ([VenueAssociatedCurriculumCourseID] ASC),
    CONSTRAINT [FK_VenueAssociatedCurriculumCourses_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]),
    CONSTRAINT [FK_VenueAssociatedCurriculumCourses_Venues] FOREIGN KEY ([VenueID]) REFERENCES [dbo].[Venues] ([VenueID])
);

