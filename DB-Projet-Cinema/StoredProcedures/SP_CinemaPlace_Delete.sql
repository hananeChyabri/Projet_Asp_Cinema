CREATE PROCEDURE [dbo].[SP_CinemaPlace_Delete]
	@id_cinemaplace INT
AS
	DELETE FROM [CinemaPlace]
		WHERE [Id_CinemaPlace] = @id_cinemaplace
