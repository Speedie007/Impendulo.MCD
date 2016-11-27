CREATE TABLE [dbo].[CourseEnrollmentTypes] (
    [CourseEnrollmentTypeID]         INT          IDENTITY (1, 1) NOT NULL,
    [EnrollmentTypeID]               INT          NOT NULL,
    [CourseID]                       INT          NOT NULL,
    [EnrollmentTypeDuration]         INT          CONSTRAINT [DF_CourseEnrollmentTypes_EnrollmentTypeDuration] DEFAULT ((1)) NOT NULL,
    [EnrollmentTypeCost]             VARCHAR (50) CONSTRAINT [DF_CourseEnrollmentTypes_EnrollmentTypeCost] DEFAULT ('Novice') NOT NULL,
    [CourseEnrollmentMaximumAllowed] INT          CONSTRAINT [DF_CourseEnrollmentTypes_CourseEnrollmentMaximumAllowed] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_CourseEnrollmentTypes] PRIMARY KEY CLUSTERED ([CourseEnrollmentTypeID] ASC),
    CONSTRAINT [FK_CourseEnrollmentTypes_Courses] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    CONSTRAINT [FK_CourseEnrollmentTypes_LookupEnrollmentTypes] FOREIGN KEY ([EnrollmentTypeID]) REFERENCES [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID])
);

