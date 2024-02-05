CREATE PROCEDURE [dbo].[SP_Diffusion_GetById]
	@id_diffusion INT
AS
	SELECT	[Id_Diffusion],
			[DiffusionDate],
			[DiffusionTime],
			[AudioLang],
			[SubTitleLang],
			[Id_CinemaRoom],
			[Id_Movie]
		FROM [Diffusion]
		WHERE [Id_Diffusion] = @id_diffusion
