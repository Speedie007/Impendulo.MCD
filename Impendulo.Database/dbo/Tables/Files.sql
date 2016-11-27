CREATE TABLE [dbo].[Files] (
    [ImageID]       INT           IDENTITY (1, 1) NOT NULL,
    [ContentType]   VARCHAR (50)  NOT NULL,
    [FileImage]     IMAGE         NOT NULL,
    [FileName]      VARCHAR (100) NOT NULL,
    [FileExtension] VARCHAR (5)   CONSTRAINT [DF_Files_FileExtension] DEFAULT ('pdf') NOT NULL,
    [DateCreated]   DATE          NOT NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED ([ImageID] ASC)
);





