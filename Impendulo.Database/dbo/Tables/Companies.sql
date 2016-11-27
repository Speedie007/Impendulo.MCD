CREATE TABLE [dbo].[Companies] (
    [CompanyID]                         INT          IDENTITY (1, 1) NOT NULL,
    [CompanyName]                       VARCHAR (50) CONSTRAINT [DF_Companies_Company] DEFAULT ('Unknown') NOT NULL,
    [CompanySETANumber]                 VARCHAR (50) CONSTRAINT [DF_Companies_CompanySETANumber] DEFAULT ('') NOT NULL,
    [CompanySicCode]                    VARCHAR (50) CONSTRAINT [DF_Companies_CompanySicCode] DEFAULT ('') NOT NULL,
    [CompanySARSLevyRegistrationNumber] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED ([CompanyID] ASC)
);





