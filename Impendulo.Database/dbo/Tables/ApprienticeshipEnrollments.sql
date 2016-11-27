CREATE TABLE [dbo].[ApprienticeshipEnrollments] (
    [EnrollmentID]                    INT NOT NULL,
    [LookupSectionalEnrollmentTypeID] INT NOT NULL,
    CONSTRAINT [PK_ApprienticeshipEnrollments] PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_ApprienticeshipEnrollments_Enrollments] FOREIGN KEY ([EnrollmentID]) REFERENCES [dbo].[Enrollments] ([EnrollmentID]),
    CONSTRAINT [FK_ApprienticeshipEnrollments_LookupSectionalEnrollmentTypes] FOREIGN KEY ([LookupSectionalEnrollmentTypeID]) REFERENCES [dbo].[LookupSectionalEnrollmentTypes] ([LookupSectionalEnrollmentTypeID])
);

