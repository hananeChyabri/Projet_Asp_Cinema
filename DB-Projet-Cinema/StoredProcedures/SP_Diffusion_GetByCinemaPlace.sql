CREATE PROCEDURE [dbo].[SP_Diffusion_GetByCinemaPlace]
	@id_cinemaPlace INT
AS
	SELECT	[Id_Diffusion],
			[DiffusionDate],
			[DiffusionTime],
			[AudioLang],
			[SubTitleLang],
			[Id_CinemaRoom],
			[Id_Movie]
		FROM [Diffusion]
		WHERE [Id_CinemaRoom] IN (
			SELECT DISTINCT [Id_CinemaRoom]
				FROM [CinemaRoom]
				WHERE [Id_CinemaPlace] = @id_cinemaPlace)
