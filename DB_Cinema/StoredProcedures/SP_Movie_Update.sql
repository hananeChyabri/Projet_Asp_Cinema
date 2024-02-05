CREATE PROCEDURE [dbo].[SP_Movie_Update]
    @id int,
	@tiltle Nvarchar(64),
	@subTitle Nvarchar(64),
	@releaseYear SMALLINT, 
    @synopsis Nvarchar(Max), 
    @posterUrl Nvarchar(256), 
    @duration INT
AS
    UPDATE Movie
    SET 
        [Tiltle] = @tiltle,
        [SubTitle] = @subTitle,
        [ReleaseYear] = @releaseYear,
        [Synopsis] = @synopsis,
        [PosterUrl] = @posterUrl,
        [Duration] = @duration
    WHERE 
        [Id_Movie] = @id;
