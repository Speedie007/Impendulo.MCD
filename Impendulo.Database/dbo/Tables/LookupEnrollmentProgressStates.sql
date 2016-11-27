CREATE TABLE [dbo].[LookupEnrollmentProgressStates] (
    [LookupEnrollmentProgressStateID] INT          IDENTITY (1, 1) NOT NULL,
    [EnrollmentProgressCurrentState]  VARCHAR (50) CONSTRAINT [DF_LookupEnrollmentProgressStates_EnrollmentProgressCurrentState] DEFAULT ('In Progress') NOT NULL,
    CONSTRAINT [PK_LookupEnrollmentProgressStates] PRIMARY KEY CLUSTERED ([LookupEnrollmentProgressStateID] ASC)
);



