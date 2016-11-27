CREATE TABLE [dbo].[LookupDisabilities] (
    [DisabilityID] INT          IDENTITY (1, 1) NOT NULL,
    [Disability]   VARCHAR (25) CONSTRAINT [DF_LookupDisabilities_Disability] DEFAULT ('None') NOT NULL,
    CONSTRAINT [PK_LookupDisabilities] PRIMARY KEY CLUSTERED ([DisabilityID] ASC)
);

