CREATE TABLE [dbo].[EmailSystemOutGoingMessageAttachments] (
    [EmailSystemOutGoingMessageAttachmentID] INT   IDENTITY (1, 1) NOT NULL,
    [EmailSystemOutGoingMessageID]           INT   NOT NULL,
    [AttachementImage]                       IMAGE NULL,
    CONSTRAINT [PK_EmailSystemOutGoingMessageAttachments] PRIMARY KEY CLUSTERED ([EmailSystemOutGoingMessageAttachmentID] ASC),
    CONSTRAINT [FK_EmailSystemOutGoingMessageAttachments_EmailSystemOutGoingMessages] FOREIGN KEY ([EmailSystemOutGoingMessageID]) REFERENCES [dbo].[EmailSystemOutGoingMessages] ([EmailSystemOutGoingMessageID])
);

