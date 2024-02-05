CREATE PROCEDURE [dbo].[SP_Movie_Select]
    @id INT
AS
BEGIN
    SELECT * FROM Movie
        WHERE [Id_Movie] = @id;
END;
GO
