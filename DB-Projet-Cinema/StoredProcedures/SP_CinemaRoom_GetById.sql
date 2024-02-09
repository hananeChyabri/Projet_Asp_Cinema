CREATE PROCEDURE [dbo].[SP_CinemaRoom_GetById]
	@id_cinemaroom INT
AS
	SELECT	[Id_CinemaRoom],
			[SeatsCount],
			[Number],
			[ScreenWidth],
			[ScreenHeight],
			[Can3D],
			[Can4DX],
			[Id_CinemaPlace]
		FROM [CinemaRoom]
		WHERE [Id_CinemaRoom] = @id_cinemaroom
