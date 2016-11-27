CREATE TABLE [dbo].[FacilitatorAssociatedCourses] (
    [FacilitatorAssociatedCourseID] INT IDENTITY (1, 1) NOT NULL,
    [IndividualID]                  INT NOT NULL,
    [CourseID]                      INT NOT NULL,
    CONSTRAINT [PK_FacilitatorAssociatedCourses] PRIMARY KEY CLUSTERED ([FacilitatorAssociatedCourseID] ASC),
    CONSTRAINT [FK_FacilitatorAssociatedCourses_Courses] FOREIGN KEY ([CourseID]) REFERENCES [dbo].[Courses] ([CourseID]),
    CONSTRAINT [FK_FacilitatorAssociatedCourses_Facilitators] FOREIGN KEY ([IndividualID]) REFERENCES [dbo].[Facilitators] ([IndividualID])
);



