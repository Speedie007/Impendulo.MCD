CREATE TABLE [dbo].[CurriculumCourseModules] (
    [CurriculumCourseModuleID] INT IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseID]       INT NOT NULL,
    [ModuleID]                 INT NOT NULL,
    CONSTRAINT [PK_CurriculumCourseModules] PRIMARY KEY CLUSTERED ([CurriculumCourseModuleID] ASC),
    CONSTRAINT [FK_CurriculumCourseModules_CurriculumCourses] FOREIGN KEY ([CurriculumCourseID]) REFERENCES [dbo].[CurriculumCourses] ([CurriculumCourseID]) ON DELETE CASCADE,
    CONSTRAINT [FK_CurriculumCourseModules_Modules] FOREIGN KEY ([ModuleID]) REFERENCES [dbo].[Modules] ([ModuleID])
);



