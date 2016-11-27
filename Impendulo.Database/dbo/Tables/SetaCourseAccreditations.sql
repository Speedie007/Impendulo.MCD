CREATE TABLE [dbo].[SetaCourseAccreditations] (
    [CourseID] INT NOT NULL,
    [SetaID]   INT NOT NULL,
    CONSTRAINT [PK_SetaCourseaccreditations] PRIMARY KEY CLUSTERED ([CourseID] ASC, [SetaID] ASC),
    CONSTRAINT [FK_SetaCourseaccreditations_Courses] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    CONSTRAINT [FK_SetaCourseaccreditations_Setas] FOREIGN KEY ([SetaID]) REFERENCES [dbo].[Setas] ([SetaID])
);

