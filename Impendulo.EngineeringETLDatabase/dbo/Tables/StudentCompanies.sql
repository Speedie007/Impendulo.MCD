CREATE TABLE [dbo].[StudentCompanies] (
    [StudentCompanyID] INT IDENTITY (1, 1) NOT NULL,
    [CompanyID]        INT NOT NULL,
    [StudentID]        INT NOT NULL,
    CONSTRAINT [PK_StudentCompanies] PRIMARY KEY CLUSTERED ([StudentCompanyID] ASC),
    CONSTRAINT [FK_StudentCompanies_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_StudentCompanies_Students] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Students] ([StudentID])
);

