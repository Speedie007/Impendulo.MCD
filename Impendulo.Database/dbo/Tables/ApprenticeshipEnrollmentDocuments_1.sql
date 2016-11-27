CREATE TABLE [dbo].[ApprenticeshipEnrollmentDocuments] (
    [ApprenticeshipEnrollmentDocumentID] INT IDENTITY (1, 1) NOT NULL,
    [EnrollmentID]                       INT NOT NULL,
    [ImageID]                            INT NOT NULL,
    [LookupEnrollentDocumentTypeID]      INT NOT NULL,
    CONSTRAINT [PK_ApprenticeshipEnrollmentDocuments] PRIMARY KEY CLUSTERED ([ApprenticeshipEnrollmentDocumentID] ASC),
    CONSTRAINT [FK_ApprenticeshipEnrollmentDocuments_ApprienticeshipEnrollments] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[ApprienticeshipEnrollments] ([EnrollmentID]),
    CONSTRAINT [FK_ApprenticeshipEnrollmentDocuments_Files] FOREIGN KEY ([ImageID]) REFERENCES [dbo].[Files] ([ImageID]),
    CONSTRAINT [FK_ApprenticeshipEnrollmentDocuments_LookupEnrollentDocumentTypes] FOREIGN KEY ([LookupEnrollentDocumentTypeID]) REFERENCES [dbo].[LookupEnrollentDocumentTypes] ([LookupEnrollentDocumentTypeID])
);

