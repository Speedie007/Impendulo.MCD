CREATE TABLE [dbo].[NextOfKins] (
    [IndividualID]     INT NOT NULL,
    [TypeOfRelationID] INT NOT NULL,
    CONSTRAINT [PK_NextOfKins_1] PRIMARY KEY CLUSTERED ([IndividualID] ASC),
    CONSTRAINT [FK_NextOfKins_Individuals] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Individuals] ([IndividualID]),
    CONSTRAINT [FK_NextOfKins_LookupTypeOfRelations] FOREIGN KEY ([TypeOfRelationID]) REFERENCES [dbo].[LookupTypeOfRelations] ([TypeOfRelationID])
);





