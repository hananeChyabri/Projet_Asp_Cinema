CREATE PROCEDURE [dbo].[SP_CinemaRoom_Delete]
	@id_cinemaroom INT
AS
	DELETE FROM [CinemaRoom]
		WHERE [Id_CinemaRoom] = @id_cinemaroom
