CREATE TABLE [dbo].[CurriculumCourses] (
    [CurriculumCourseID]       INT             IDENTITY (1, 1) NOT NULL,
    [CurriculumCourseParentID] INT             CONSTRAINT [DF_CurriculumCourses_CurriculumCourseParentID] DEFAULT ((0)) NOT NULL,
    [CurriculumID]             INT             NOT NULL,
    [CourseID]                 INT             NOT NULL,
    [EnrollmentTypeID]         INT             NOT NULL,
    [Duration]                 INT             CONSTRAINT [DF_CurriculumCourses_Duration] DEFAULT ((1)) NOT NULL,
    [Cost]                     DECIMAL (10, 2) CONSTRAINT [DF_CurriculumCourses_Cost] DEFAULT ((0.00)) NOT NULL,
    CONSTRAINT [PK_CurriculumCourses] PRIMARY KEY CLUSTERED ([CurriculumCourseID] ASC),
    CONSTRAINT [FK_CurriculumCourses_Courses] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    CONSTRAINT [FK_CurriculumCourses_Curriculums] FOREIGN KEY ([CurriculumID]) REFERENCES [dbo].[Curriculums] ([CurriculumID]),
    CONSTRAINT [FK_CurriculumCourses_LookupEnrollmentTypes] FOREIGN KEY ([EnrollmentTypeID]) REFERENCES [dbo].[LookupEnrollmentTypes] ([EnrollmentTypeID])
);



