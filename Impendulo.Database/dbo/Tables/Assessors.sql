CREATE TABLE [dbo].[Assessors] (
    [IndividualID] INT NOT NULL,
    CONSTRAINT [PK_Assessors] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_Assessors_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]) ON DELETE CASCADE
);




