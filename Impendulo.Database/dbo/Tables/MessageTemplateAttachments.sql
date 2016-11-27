CREATE TABLE [dbo].[MessageTemplateAttachments] (
    [MessageTemplateID] INT NOT NULL,
    [ImageID]           INT NOT NULL,
    CONSTRAINT [PK_MessageTemplateAttachments] PRIMARY KEY CLUSTERED ([MessageTemplateID] ASC, [ImageID] ASC),
    CONSTRAINT [FK_MessageTemplateAttachments_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID]),
    CONSTRAINT [FK_MessageTemplateAttachments_MessageTemplates] FOREIGN KEY ([MessageTemplateID]) REFERENCES [dbo].[MessageTemplates] ([MessageTemplateID])
);

