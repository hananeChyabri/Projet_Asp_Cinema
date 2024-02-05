CREATE PROCEDURE [dbo].[SP_Movie_GetAll]
AS
	SELECT	[Id_Movie],
			[Title],
			[SubTitle],
			[ReleaseYear],
			[Synopsis],
			[PosterUrl],
			[Duration]
		FROM [Movie]
