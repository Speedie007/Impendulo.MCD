CREATE TABLE [dbo].[Individuals] (
    [IndividualID]         INT          IDENTITY (1, 1) NOT NULL,
    [TitleID]              INT          CONSTRAINT [DF_Individuals_TitleID] DEFAULT ((1)) NOT NULL,
    [IndividualFirstName]  VARCHAR (30) CONSTRAINT [DF_Individuals_IndividualFirstName] DEFAULT ('Unknown') NOT NULL,
    [IndividualSecondName] VARCHAR (30) CONSTRAINT [DF_Individuals_IndividualSecondName] DEFAULT ('') NOT NULL,
    [IndividualLastname]   VARCHAR (30) CONSTRAINT [DF_Individuals_IndividualLastname] DEFAULT ('Unknown') NOT NULL,
    [RowVersion]           ROWVERSION   NOT NULL,
    CONSTRAINT [PK_Individuals] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_Individuals_LookupTitles] FOREIGN KEY ([TitleID]) REFERENCES [dbo].[LookupTitles] ([TitleID])
);









