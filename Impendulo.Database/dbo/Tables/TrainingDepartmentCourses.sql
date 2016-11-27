CREATE TABLE [dbo].[TrainingDepartmentCourses] (
    [TrainingDepartmentCourseID]   INT           IDENTITY (1, 1) NOT NULL,
    [TrainingDepartmentID]         INT           NOT NULL,
    [TrainingDepartmentCourseName] VARCHAR (250) NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED ([TrainingDepartmentCourseID] ASC),
    CONSTRAINT [FK_Courses_TrainingDepartments] FOREIGN KEY ([TrainingDepartmentID]) REFERENCES [dbo].[TrainingDepartments] ([TrainingDepartmentID])
);

