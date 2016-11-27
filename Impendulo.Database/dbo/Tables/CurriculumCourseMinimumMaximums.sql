CREATE TABLE [dbo].[CurriculumCourseMinimumMaximums] (
    [CurriculumCourseID]      INT NOT NULL,
    [CurriculumCourseMinimum] INT CONSTRAINT [DF_CurriculumCourseMinimumMaximums_CurriculumCourseMinimum] DEFAULT ((1)) NOT NULL,
    [CurriculumCourseMaximum] INT CONSTRAINT [DF_CurriculumCourseMinimumMaximums_CurriculumCourseMaximum] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_CurriculumCourseMinimumMaximums_1] PRIMARY KEY CLUSTERED ([CurriculumCourseID] ASC),
    CONSTRAINT [FK_CurriculumCourseMinimumMaximums_CurriculumCourses1] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]) ON DELETE CASCADE
);





