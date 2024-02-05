CREATE PROCEDURE [dbo].[SP_Diffusion_Update]
	@id_diffusion INT,
	@diffusionDate DATE,
	@diffusionTime TIME,
	@audioLang VARCHAR(16),
	@subtitleLang VARCHAR(16),
	@id_cinemaRoom INT,
	@id_movie INT
AS
	UPDATE [Diffusion] 
		SET [DiffusionDate] = @diffusionDate,
			[DiffusionTime] = @diffusionTime,
			[AudioLang] = @audioLang,
			[SubTitleLang] = @subtitleLang,
			[Id_CinemaRoom] = @id_cinemaRoom,
			[Id_Movie] = @id_movie
		WHERE [Id_Diffusion] = @id_diffusion