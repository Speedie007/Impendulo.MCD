CREATE TABLE [dbo].[LookupTitles] (
    [TitleID] INT          IDENTITY (1, 1) NOT NULL,
    [Title]   VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_LookupTitles] PRIMARY KEY CLUSTERED ([TitleID] ASC)
);

