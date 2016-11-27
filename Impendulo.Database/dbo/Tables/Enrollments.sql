CREATE TABLE [dbo].[Enrollments] (
    [EnrollmentID]                    INT  IDENTITY (1, 1) NOT NULL,
    [EnrolmentParentID]               INT  CONSTRAINT [DF_Enrollments_EnrolmentParentID] DEFAULT ((0)) NULL,
    [EnrollmentExcempt]               BIT  CONSTRAINT [DF_Enrollments_EnrollmentExcempt] DEFAULT ((0)) NULL,
    [LookupEnrollmentProgressStateID] INT  NOT NULL,
    [CurriculumID]                    INT  NOT NULL,
    [DateIntitiated]                  DATE CONSTRAINT [DF_Enrollments_DateIntitiated] DEFAULT (getdate()) NOT NULL,
    [IndividualID]                    INT  NOT NULL,
    CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_Enrollments_Curriculums] FOREIGN KEY ([CurriculumID]) REFERENCES [dbo].[Curriculums] ([CurriculumID]),
    CONSTRAINT [FK_Enrollments_LookupEnrollmentProgressStates] FOREIGN KEY ([LookupEnrollmentProgressStateID]) REFERENCES [dbo].[LookupEnrollmentProgressStates] ([LookupEnrollmentProgressStateID]),
    CONSTRAINT [FK_Enrollments_Students] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Students] ([IndividualID])
);









