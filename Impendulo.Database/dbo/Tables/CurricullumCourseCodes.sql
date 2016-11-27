CREATE TABLE [dbo].[CurricullumCourseCodes] (
    [CurriculumCourseID]    INT          NOT NULL,
    [CurricullumCourseCode] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CurricullumCourseCodes] PRIMARY KEY CLUSTERED ([CurriculumCourseID] ASC),
    CONSTRAINT [FK_CurricullumCourseCodes_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]) ON DELETE CASCADE
);



