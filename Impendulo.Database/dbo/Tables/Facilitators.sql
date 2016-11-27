CREATE TABLE [dbo].[Facilitators] (
    [IndividualID] INT NOT NULL,
    CONSTRAINT [PK_Facilitator] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_Facilitators_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]) ON DELETE CASCADE
);



