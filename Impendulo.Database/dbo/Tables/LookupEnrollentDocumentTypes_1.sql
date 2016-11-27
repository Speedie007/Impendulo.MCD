CREATE TABLE [dbo].[LookupEnrollentDocumentTypes] (
    [LookupEnrollentDocumentTypeID] INT           IDENTITY (1, 1) NOT NULL,
    [EnrollentDocumentType]         VARCHAR (200) CONSTRAINT [DF_LookupEnrollentDocumentTypes_EnrollentDocumentType] DEFAULT ('Unknown') NOT NULL,
    CONSTRAINT [PK_LookupEnrollentDocumentTypes] PRIMARY KEY CLUSTERED ([LookupEnrollentDocumentTypeID] ASC)
);

