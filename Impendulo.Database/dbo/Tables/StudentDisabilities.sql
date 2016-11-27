CREATE TABLE [dbo].[StudentDisabilities] (
    [StudentDisabilityID]    INT            IDENTITY (1, 1) NOT NULL,
    [IndividualID]           INT            NOT NULL,
    [DisabilityID]           INT            NOT NULL,
    [StudentDisabilityNotes] VARCHAR (1000) CONSTRAINT [DF_StudentDisabilities_StudentDisabilityNotes] DEFAULT ('None') NOT NULL,
    CONSTRAINT [PK_StudentDisabilities] PRIMARY KEY CLUSTERED ([StudentDisabilityID] ASC),
    CONSTRAINT [FK_StudentDisabilities_LookupDisabilities] FOREIGN KEY ([DisabilityID]) REFERENCES [dbo].[LookupDisabilities] ([DisabilityID]),
    CONSTRAINT [FK_StudentDisabilities_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID])
);







