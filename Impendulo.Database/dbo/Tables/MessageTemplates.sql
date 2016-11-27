CREATE TABLE [dbo].[MessageTemplates] (
    [MessageTemplateID] INT           IDENTITY (1, 1) NOT NULL,
    [ProcessStepID]     INT           NOT NULL,
    [Message]           VARCHAR (MAX) NOT NULL,
    [DateLastUpdated]   DATETIME      NOT NULL,
    CONSTRAINT [PK_MessageTemplates] PRIMARY KEY CLUSTERED ([MessageTemplateID] ASC),
    CONSTRAINT [FK_MessageTemplates_LookupProcessSteps] FOREIGN KEY ([ProcessStepID]) REFERENCES [dbo].[LookupProcessSteps] ([ProcessStepID])
);

