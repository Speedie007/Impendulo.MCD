CREATE TABLE [dbo].[CurriculumCourseAssociatedSetas] (
    [SetaID]             INT NOT NULL,
    [CurriculumCourseID] INT NOT NULL,
    CONSTRAINT [PK_CurriculumCourseAssociatedSetas] PRIMARY KEY CLUSTERED ([SetaID] ASC, [CurriculumCourseID] ASC),
    CONSTRAINT [FK_CurriculumCourseAssociatedSetas_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CurriculumCourseAssociatedSetas_Setas] FOREIGN KEY ([SetaID]) REFERENCES [dbo].[LookupSetas] ([SetaID])
);





