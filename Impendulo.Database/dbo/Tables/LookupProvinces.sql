CREATE TABLE [dbo].[LookupProvinces] (
    [ProvinceID] INT          IDENTITY (1, 1) NOT NULL,
    [Province]   VARCHAR (50) CONSTRAINT [DF_LookupProvinces_Province] DEFAULT ('Unknown') NOT NULL,
    CONSTRAINT [PK_LookupProvinces] PRIMARY KEY CLUSTERED ([ProvinceID] ASC)
);

