CREATE TABLE [dbo].[Employees] (
    [IndividualID]   INT           NOT NULL,
    [EmployeeNumber] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_Employees_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]) ON DELETE CASCADE
);













