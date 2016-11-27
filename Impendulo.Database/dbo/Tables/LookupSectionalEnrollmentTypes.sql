CREATE TABLE [dbo].[LookupSectionalEnrollmentTypes] (
    [LookupSectionalEnrollmentTypeID] INT          IDENTITY (1, 1) NOT NULL,
    [LookupSectionalEnrollmentType]   VARCHAR (50) NULL,
    CONSTRAINT [PK_LookupSectionalEnrollmentTypes] PRIMARY KEY CLUSTERED ([LookupSectionalEnrollmentTypeID] ASC)
);



