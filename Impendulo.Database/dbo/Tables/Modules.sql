CREATE TABLE [dbo].[Modules] (
    [ModuleID]     INT           IDENTITY (1, 1) NOT NULL,
    [DepartmentID] INT           CONSTRAINT [DF_Modules_DepartmentID] DEFAULT ((2004)) NOT NULL,
    [ModuleName]   VARCHAR (100) NULL,
    CONSTRAINT [PK_Modules] PRIMARY KEY CLUSTERED ([ModuleID] ASC),
    CONSTRAINT [FK_Modules_Departments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
);























