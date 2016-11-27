CREATE TABLE [dbo].[CourseSchedules] (
    [CourseScheduleID]        INT  IDENTITY (1, 1) NOT NULL,
    [IndividualID]            INT  NOT NULL,
    [CourseScheduleStartDate] DATE NOT NULL,
    [CourseScheduleEndDate]   DATE NOT NULL,
    CONSTRAINT [PK_CourseSchedules] PRIMARY KEY CLUSTERED ([CourseScheduleID] ASC),
    CONSTRAINT [FK_CourseSchedules_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID])
);



