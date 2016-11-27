CREATE TABLE [dbo].[LookupGenders] (
    [GenderID] INT          NOT NULL IDENTITY,
    [Gender]   VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_LookupGenders] PRIMARY KEY CLUSTERED ([GenderID] ASC)
);

