CREATE TABLE [dbo].[LookupProcessSteps] (
    [ProcessStepID] INT           IDENTITY (1, 1) NOT NULL,
    [ProcessStep]   VARCHAR (500) NOT NULL,
    [ProcessID]     INT           NOT NULL,
    CONSTRAINT [PK_LookupProcessSteps] PRIMARY KEY CLUSTERED ([ProcessStepID] ASC),
    CONSTRAINT [FK_LookupProcessSteps_LookupProcesses] FOREIGN KEY ([ProcessID]) REFERENCES [dbo].[LookupProcesses] ([ProcessID])
);



