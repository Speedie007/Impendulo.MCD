CREATE TABLE [dbo].[LookupCountries] (
    [CountryID]   INT          IDENTITY (1, 1) NOT NULL,
    [CountryName] VARCHAR (50) CONSTRAINT [DF_LookupCountries_Country] DEFAULT ('South Africa') NOT NULL,
    [CountryCode] VARCHAR (10) CONSTRAINT [DF_LookupCountries_CountryCode] DEFAULT ('ZAR') NOT NULL,
    CONSTRAINT [PK_LookupCountries] PRIMARY KEY CLUSTERED ([CountryID] ASC)
);

