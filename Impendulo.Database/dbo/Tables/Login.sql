CREATE TABLE [dbo].[Login] (
    [LoginID]         INT          IDENTITY (1, 1) NOT NULL,
    [IndividualID]    INT          NOT NULL,
    [DateLastChanged] DATETIME     CONSTRAINT [DF_Login_DateLastChanged] DEFAULT (getdate()) NOT NULL,
    [UserName]        VARCHAR (50) NOT NULL,
    [Password]        VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([LoginID] ASC),
    CONSTRAINT [FK_Login_Employees] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Employees] ([IndividualID])
);

