CREATE TABLE [dbo].[LookupDepartments] (
    [DepartmentID]   INT           IDENTITY (1, 1) NOT NULL,
    [DepartmentName] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Departments_1] PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);



