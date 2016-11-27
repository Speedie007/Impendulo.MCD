CREATE TABLE [dbo].[LookupEnrollmentTypes] (
    [EnrollmentTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [EnrollmentType]   VARCHAR (50) NULL,
    CONSTRAINT [PK_LookupEnrollmentTypes] PRIMARY KEY CLUSTERED ([EnrollmentTypeID] ASC)
);

