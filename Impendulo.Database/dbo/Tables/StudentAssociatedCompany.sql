CREATE TABLE [dbo].[StudentAssociatedCompany] (
    [StudentAssosiatedCompanyID] INT IDENTITY (1, 1) NOT NULL,
    [IndividualID]               INT NOT NULL,
    [CompanyID]                  INT NOT NULL,
    [IsCurrentCompany]           BIT CONSTRAINT [DF_StudentAssociatedCompany_IsCurrentCompany] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_StudentAssociatedCompany] PRIMARY KEY CLUSTERED ([StudentAssosiatedCompanyID] ASC),
    CONSTRAINT [FK_StudentAssociatedCompany_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID]),
    CONSTRAINT [FK_StudentAssociatedCompany_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID])
);







