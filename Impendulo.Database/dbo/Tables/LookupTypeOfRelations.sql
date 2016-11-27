CREATE TABLE [dbo].[LookupTypeOfRelations] (
    [TypeOfRelationID] INT          IDENTITY (1, 1) NOT NULL,
    [TypeOfRelation]   VARCHAR (50) CONSTRAINT [DF_LookupTypeOfRelations_TypeOfRelation] DEFAULT ('Unknown') NOT NULL,
    CONSTRAINT [PK_LookupTypeOfRelations] PRIMARY KEY CLUSTERED ([TypeOfRelationID] ASC)
);

