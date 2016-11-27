CREATE TABLE [dbo].[Curriculums] (
    [CurriculumID]          INT           IDENTITY (1, 1) NOT NULL,
    [CostingModelID]        INT           CONSTRAINT [DF_Curriculums_CostingModelID] DEFAULT ((1)) NOT NULL,
    [DepartmentID]          INT           NOT NULL,
    [CurriculumName]        VARCHAR (100) NOT NULL,
    [CurriculumIsSequenced] BIT           CONSTRAINT [DF_Curriculums_CurriculumIsSequenced] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Curriculums_1] PRIMARY KEY CLUSTERED ([CurriculumID] ASC),
    CONSTRAINT [FK_Curriculums_CostingModels] FOREIGN KEY ([CostingModelID]) REFERENCES [dbo].[CostingModels] ([CostingModelID]),
    CONSTRAINT [FK_Curriculums_Departments] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[LookupDepartments] ([DepartmentID])
);





