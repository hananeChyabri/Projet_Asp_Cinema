CREATE PROCEDURE [dbo].[SP_CinemaRoom_GetAll]
AS
	SELECT	[Id_CinemaRoom],
			[SeatsCount],
			[Number],
			[ScreenWidth],
			[ScreenHeight],
			[Can3D],
			[Can4DX]
		FROM [CinemaRoom]
