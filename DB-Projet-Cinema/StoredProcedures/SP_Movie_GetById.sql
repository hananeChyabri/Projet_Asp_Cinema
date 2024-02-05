CREATE PROCEDURE [dbo].[SP_Movie_GetById]
	@id_movie INT
AS
	SELECT	[Id_Movie],
			[Title],
			[SubTitle],
			[ReleaseYear],
			[Synopsis],
			[PosterUrl],
			[Duration]
		FROM [Movie]
		WHERE [Id_Movie] = @id_movie
