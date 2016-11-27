CREATE TABLE [dbo].[Courses] (
    [CourseID]          INT            IDENTITY (1, 1) NOT NULL,
    [DepartmentID]      INT            NOT NULL,
    [CourseName]        VARCHAR (500)  CONSTRAINT [DF_Courses_CourseName_1] DEFAULT ('Unknown') NOT NULL,
    [CourseDescription] VARCHAR (1000) CONSTRAINT [DF_Courses_CourseDescription_1] DEFAULT ('None') NOT NULL,
    CONSTRAINT [PK_Courses_2] PRIMARY KEY CLUSTERED ([CourseID] ASC),
    CONSTRAINT [FK_Courses_Departments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
);














GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Courses]
    ON [dbo].[Courses]([CourseName] ASC);

