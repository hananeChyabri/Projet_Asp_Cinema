CREATE PROCEDURE [dbo].[SP_Movie_Update]
	@id_movie INT,
	@title NVARCHAR(64),
	@subTitle NVARCHAR(64),
	@releaseYear SMALLINT,
	@synopsis NVARCHAR(MAX),
	@posterUrl NVARCHAR(256),
	@duration INT
AS
	UPDATE [Movie] 
		SET [Title] = @title ,
			[SubTitle] = @subTitle ,
			[ReleaseYear] = @releaseYear ,
			[Synopsis] = @synopsis ,
			[PosterUrl] = @posterUrl ,
			[Duration] = @duration
		WHERE [Id_Movie] = @id_movie