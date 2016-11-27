CREATE TABLE [dbo].[FacilitatorSetaAccreditations] (
    [FacilitatorSetaAccreditationID] INT IDENTITY (1, 1) NOT NULL,
    [IndividualID]                   INT NOT NULL,
    CONSTRAINT [PK_FacilitatorSetaAccreditations] PRIMARY KEY CLUSTERED ([FacilitatorSetaAccreditationID] ASC),
    CONSTRAINT [FK_FacilitatorSetaAccreditations_Facilitators] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Facilitators] ([IndividualID])
);

