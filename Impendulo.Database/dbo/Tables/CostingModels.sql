CREATE TABLE [dbo].[CostingModels] (
    [CostingModelID]   INT          IDENTITY (1, 1) NOT NULL,
    [CostingModelName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_CostingModels] PRIMARY KEY CLUSTERED ([CostingModelID] ASC)
);

