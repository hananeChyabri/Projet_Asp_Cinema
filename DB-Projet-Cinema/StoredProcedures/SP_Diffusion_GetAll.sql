CREATE PROCEDURE [dbo].[SP_Diffusion_GetAll]
AS
	SELECT	[Id_Diffusion],
			[DiffusionDate],
			[DiffusionTime],
			[AudioLang],
			[SubTitleLang],
			[Id_CinemaRoom],
			[Id_Movie]
		FROM [Diffusion]
