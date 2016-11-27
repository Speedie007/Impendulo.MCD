CREATE TABLE [dbo].[Students] (
    [IndividualID]           INT          NOT NULL,
    [QualificationLevelID]   INT          NOT NULL,
    [MartialStatusID]        INT          NOT NULL,
    [GenderID]               INT          NOT NULL,
    [EthnicityID]            INT          NOT NULL,
    [StudentIDNumber]        VARCHAR (15) CONSTRAINT [DF_Students_IndividualIDNumber] DEFAULT ((1234567891234.)) NOT NULL,
    [StudentCurrentPosition] VARCHAR (50) CONSTRAINT [DF_Students_StudentCurrentPosition] DEFAULT ('Unknown') NOT NULL,
    [StudentlInitialDate]    DATETIME     CONSTRAINT [DF_Students_IndividualInitialDate] DEFAULT (getdate()) NOT NULL,
    [RowVersion]             ROWVERSION   NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_Students_Individuals1] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]),
    CONSTRAINT [FK_Students_LookupEthnicities] FOREIGN KEY ([EthnicityID]) REFERENCES [dbo].[LookupEthnicities] ([EthnicityID]),
    CONSTRAINT [FK_Students_LookupGenders] FOREIGN KEY ([GenderID]) REFERENCES [dbo].[LookupGenders] ([GenderID]),
    CONSTRAINT [FK_Students_LookupMartialStatuses] FOREIGN KEY ([MartialStatusID]) REFERENCES [dbo].[LookupMartialStatuses] ([MartialStatusID]),
    CONSTRAINT [FK_Students_LookupQualificationLevels] FOREIGN KEY ([QualificationLevelID]) REFERENCES [dbo].[LookupQualificationLevels] ([QualificationLevelID])
);











