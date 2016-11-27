CREATE TABLE [dbo].[FacilitatorQualifications] (
    [FacilitatorQualificationID] INT IDENTITY (1, 1) NOT NULL,
    [QualificationID]            INT NOT NULL,
    [IndividualID]               INT NOT NULL,
    CONSTRAINT [PK_FacilitatorQualifications] PRIMARY KEY CLUSTERED ([FacilitatorQualificationID] ASC),
    CONSTRAINT [FK_FacilitatorQualifications_Facilitators] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Facilitators] ([IndividualID]),
    CONSTRAINT [FK_FacilitatorQualifications_Qualifications] FOREIGN KEY ([QualificationID]) REFERENCES [dbo].[Qualifications] ([QualificationID])
);

