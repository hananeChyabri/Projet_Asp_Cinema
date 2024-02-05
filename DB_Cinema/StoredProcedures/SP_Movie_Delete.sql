CREATE PROCEDURE [dbo].[SP_Movie_Delete]
    @id INT
AS
BEGIN
    DELETE FROM Movie
        WHERE [Id_Movie] = @id;
END;
GO

