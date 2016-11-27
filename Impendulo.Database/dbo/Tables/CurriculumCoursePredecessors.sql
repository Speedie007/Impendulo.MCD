CREATE TABLE [dbo].[CurriculumCoursePredecessors] (
    [CurriculumCoursePredecessorID] INT IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseID]            INT NOT NULL,
    [PredecessorCurriculumCourseID] INT NOT NULL,
    CONSTRAINT [PK_CurriculumCoursePredecessors] PRIMARY KEY CLUSTERED ([CurriculumCoursePredecessorID] ASC),
    CONSTRAINT [FK_CurriculumCoursePredecessors_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID])
);

