CREATE TABLE [dbo].[LookupProcesses] (
    [ProcessID]   INT          IDENTITY (1, 1) NOT NULL,
    [ProcessName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_LookupProcesses] PRIMARY KEY CLUSTERED ([ProcessID] ASC)
);

