CREATE TABLE [dbo].[FacilitatorAssociatedCurriculumCourses] (
    [FacilitatorAssociatedCurriculumCourseID] INT IDENTITY (1, 1) NOT NULL,
    [IndividualID]                            INT NOT NULL,
    [CurriculumCourseID]                      INT NOT NULL,
    CONSTRAINT [PK_FacilitatorAssociatedCurriculumCourses] PRIMARY KEY CLUSTERED ([FacilitatorAssociatedCurriculumCourseID] ASC),
    CONSTRAINT [FK_FacilitatorAssociatedCurriculumCourses_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]),
    CONSTRAINT [FK_FacilitatorAssociatedCurriculumCourses_Facilitators] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Facilitators] ([IndividualID])
);

