CREATE TABLE [dbo].[CurriculumCourseModuleActivities] (
    [CurriculumCourseModuleID] INT NOT NULL,
    [ActivityID]               INT NOT NULL,
    CONSTRAINT [PK_CurriculumCourseModuleActivities] PRIMARY KEY CLUSTERED ([CurriculumCourseModuleID] ASC, [ActivityID] ASC),
    CONSTRAINT [FK_CurriculumCourseModuleActivities_Activities] FOREIGN KEY ([ActivityID]) REFERENCES [dbo].[Activities] ([ActivityID]),
    CONSTRAINT [FK_CurriculumCourseModuleActivities_CurriculumCourseModules] FOREIGN KEY ([CurriculumCourseModuleID]) REFERENCES [dbo].[CurriculumCourseModules] ([CurriculumCourseModuleID]) ON DELETE CASCADE
);



