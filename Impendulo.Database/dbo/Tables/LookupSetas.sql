CREATE TABLE [dbo].[LookupSetas] (
    [SetaID]           INT          IDENTITY (1, 1) NOT NULL,
    [SetsName]         VARCHAR (50) NOT NULL,
    [SetaAbbriviation] VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Setas] PRIMARY KEY CLUSTERED ([SetaID] ASC)
);

