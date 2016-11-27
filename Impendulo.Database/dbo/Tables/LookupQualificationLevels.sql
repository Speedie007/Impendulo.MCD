CREATE TABLE [dbo].[LookupQualificationLevels] (
    [QualificationLevelID] INT           IDENTITY (1, 1) NOT NULL,
    [QualificationLevel]   VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_LookupQualifications] PRIMARY KEY CLUSTERED ([QualificationLevelID] ASC)
);



