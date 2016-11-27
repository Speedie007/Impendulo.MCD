CREATE TABLE [dbo].[Activities] (
    [ActivityID]           INT            IDENTITY (1, 1) NOT NULL,
    [ModuleID]             INT            NOT NULL,
    [ActivityCode]         VARCHAR (20)   CONSTRAINT [DF_Activities_ActivityCode] DEFAULT ((0)) NOT NULL,
    [ActivitiyDescription] VARCHAR (2000) CONSTRAINT [DF_Activities_ActivitiyDescription] DEFAULT ('None') NOT NULL,
    CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED ([ActivityID] ASC),
    CONSTRAINT [FK_Activities_Modules] FOREIGN KEY ([ModuleID]) REFERENCES [dbo].[Modules] ([ModuleID])
);





