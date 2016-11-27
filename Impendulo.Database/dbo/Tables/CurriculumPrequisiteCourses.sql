CREATE TABLE [dbo].[CurriculumPrequisiteCourses] (
    [CurriculumPrequisiteCourseID] INT IDENTITY (1, 1) NOT NULL,
    [CurriculumID]                 INT NOT NULL,
    [CurriculumCourseID]           INT NOT NULL,
    CONSTRAINT [PK_CurriculumPrequisiteCourses] PRIMARY KEY CLUSTERED ([CurriculumPrequisiteCourseID] ASC),
    CONSTRAINT [FK_CurriculumPrequisiteCourses_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]),
    CONSTRAINT [FK_CurriculumPrequisiteCourses_Curriculums] FOREIGN KEY ([CurriculumID]) REFERENCES [dbo].[Curriculums] ([CurriculumID])
);

