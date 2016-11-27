CREATE TABLE [dbo].[EquiryHistory] (
    [EnqueryHistoryID]         INT           IDENTITY (1, 1) NOT NULL,
    [EnquiryID]                INT           NOT NULL,
    [IndividualID]             INT           NOT NULL,
    [LookupEquiyHistoryTypeID] INT           NOT NULL,
    [DateEnquiryUpdated]       DATETIME      CONSTRAINT [DF_EquiryHistory_EnquiryHistoryDateCommunication Completed] DEFAULT (getdate()) NOT NULL,
    [EnquiryNotes]             VARCHAR (MAX) CONSTRAINT [DF_EquiryHistory_EnquiryNotes] DEFAULT ('None') NOT NULL,
    CONSTRAINT [PK_EquiryHistory] PRIMARY KEY CLUSTERED ([EnqueryHistoryID] ASC),
    CONSTRAINT [FK_EquiryHistory_Employees] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Employees] ([IndividualID]),
    CONSTRAINT [FK_EquiryHistory_Enquiry] FOREIGN KEY ([EnquiryID]) REFERENCES [dbo].[Enquiry] ([EnquiryID]),
    CONSTRAINT [FK_EquiryHistory_LookupEquiryHistoryTypes] FOREIGN KEY ([LookupEquiyHistoryTypeID]) REFERENCES [dbo].[LookupEquiryHistoryTypes] ([LookupEquiyHistoryTypeID])
);









