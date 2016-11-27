CREATE TABLE [dbo].[Schedules] (
    [ScheduleID]                   INT  IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseEnrollmentID] INT  NOT NULL,
    [ScheduleStartDate]            DATE CONSTRAINT [DF_Schedules_ScheduleStartDate] DEFAULT (getdate()) NOT NULL,
    [ScheduleCompletionDate]       DATE CONSTRAINT [DF_Schedules_ScheduleStartDate1] DEFAULT (getdate()) NOT NULL,
    [EnrollmentID]                 INT  NOT NULL,
    CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED ([ScheduleID] ASC),
    CONSTRAINT [FK_Schedules_CurriculumCourseEnrollments] FOREIGN KEY ([CurriculumCourseEnrollmentID]) REFERENCES [dbo].[CurriculumCourseEnrollments] ([CurriculumCourseEnrollmentID]),
    CONSTRAINT [FK_Schedules_Enrollments] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID])
);



