CREATE TABLE [dbo].[StudentNextOfKins] (
    [StudentID]   INT NOT NULL,
    [NextOfKinID] INT NOT NULL,
    CONSTRAINT [PK_StudentNextOfKins] PRIMARY KEY CLUSTERED ([StudentID] ASC, [NextOfKinID] ASC),
    CONSTRAINT [FK_StudentNextOfKins_NextOfKins] FOREIGN KEY ([NextOfKinID]) REFERENCES [dbo].[NextOfKins] ([IndividualID]),
    CONSTRAINT [FK_StudentNextOfKins_Students] FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Students] ([IndividualID])
);

