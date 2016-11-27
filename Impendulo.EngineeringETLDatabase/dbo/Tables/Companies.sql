CREATE TABLE [dbo].[Companies] (
    [CompanyID]                 INT          IDENTITY (1, 1) NOT NULL,
    [CompanyNameOriginalValue]  VARCHAR (50) NULL,
    [CompanyNameCorrectedValue] VARCHAR (50) NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);

