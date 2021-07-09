CREATE PROCEDURE [dbo].[spListCourses] 
 @CursoId INT
AS
BEGIN
    SELECT * 
    FROM [Curso]  a
    WHERE a.Id = @CursoId
END

exec spListCourses 1