CREATE TABLE [dbo].[LookupEthnicities] (
    [EthnicityID] INT          IDENTITY (1, 1) NOT NULL,
    [Ethnicity]   VARCHAR (25) NULL,
    CONSTRAINT [PK_LookupEthnicity] PRIMARY KEY CLUSTERED ([EthnicityID] ASC)
);

