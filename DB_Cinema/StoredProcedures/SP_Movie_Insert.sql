CREATE PROCEDURE [dbo].[SP_Movie_Insert]
	@tiltle Nvarchar(64),
	@subTitle Nvarchar(64),
	@releaseYear SMALLINT, 
    @synopsis Nvarchar(Max), 
    @posterUrl Nvarchar(256), 
    @duration INT
AS
	INSERT INTO [Movie] ([tiltle],[subTitle],[ReleaseYear],[synopsis],[posterUrl],[duration])
	OUTPUT [inserted].[Id_Movie]
	VALUES (@tiltle,@subTitle,@releaseYear,@synopsis,@posterUrl,@duration)
RETURN 
