CREATE TABLE [dbo].[Students] (
    [StudentID]                       INT          IDENTITY (1, 1) NOT NULL,
    [StudentIDNumberOriginalValue]    VARCHAR (15) NULL,
    [StudentIDNumberCorrectedValue]   VARCHAR (15) NULL,
    [StudentFirstNameOriginalValue]   VARCHAR (50) NULL,
    [StudentFirstNameCorrectedValue]  VARCHAR (50) NULL,
    [StudentSecondNameOriginalvalue]  VARCHAR (50) NULL,
    [StudentSecondNameCorrectedValue] VARCHAR (50) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([StudentID] ASC)
);



