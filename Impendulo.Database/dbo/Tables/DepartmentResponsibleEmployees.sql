CREATE TABLE [dbo].[DepartmentResponsibleEmployees] (
    [DepartmentID] INT NOT NULL,
    [IndividualID] INT NOT NULL,
    CONSTRAINT [PK_DepartmentResponsibleEmployees] PRIMARY KEY CLUSTERED ([DepartmentID] ASC, [IndividualID] ASC),
    CONSTRAINT [FK_DepartmentResponsibleEmployees_Employees] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Employees] ([IndividualID]),
    CONSTRAINT [FK_DepartmentResponsibleEmployees_LookupDepartments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
);

