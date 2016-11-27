CREATE TABLE [dbo].[SystemAdministrator] (
    [SystemAdministratorID] INT          NOT NULL,
    [SystemUserName]        VARCHAR (50) NOT NULL,
    [SystemUserPassword]    VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SystemAdministrator] PRIMARY KEY CLUSTERED ([SystemAdministratorID] ASC),
    CONSTRAINT [FK_SystemAdministrator_Individuals] FOREIGN KEY ([SystemAdministratorID]) REFERENCES [dbo].[Individuals] ([IndividualID])
);

