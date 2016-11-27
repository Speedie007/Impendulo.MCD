-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE InsertMissingCourses
--drOP PROCEDURE InsertMissingCourses
	-- Add the parameters for the stored procedure here
	@CourseID int,
	@DepartmentID int,
	@CourseName varchar(250),
	@CourseDescription varchar(1000)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SET IDENTITY_INSERT [dbo].[Courses] ON ;

INSERT [dbo].[Courses] ([CourseID], [DepartmentID], [CourseName], [CourseDescription]) VALUES (@CourseID, @DepartmentID, @CourseName,@CourseDescription);

--SET IDENTITY_INSERT [dbo].[Courses] OFF ;
END