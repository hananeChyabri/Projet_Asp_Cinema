CREATE PROCEDURE [dbo].[SP_Movie_Insert]
	@title NVARCHAR(64),
	@subTitle NVARCHAR(64),
	@releaseYear SMALLINT,
	@synopsis NVARCHAR(MAX),
	@posterUrl NVARCHAR(256),
	@duration INT
AS
	INSERT INTO [Movie] ([Title],[SubTitle],[ReleaseYear],[Synopsis],[PosterUrl],[Duration])
		OUTPUT [inserted].[Id_Movie]
		VALUES (@title,@subTitle,@releaseYear,@synopsis,@posterUrl,@duration)
