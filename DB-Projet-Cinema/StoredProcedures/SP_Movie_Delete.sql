CREATE PROCEDURE [dbo].[SP_Movie_Delete]
	@id_movie INT
AS
	DELETE FROM [Movie]
		WHERE [Id_Movie] = @id_movie
