CREATE PROCEDURE [dbo].[SP_Diffusion_Insert]
	@diffusionDate DATE,
	@diffusionTime TIME,
	@audioLang VARCHAR(16),
	@subtitleLang VARCHAR(16),
	@id_cinemaRoom INT,
	@id_movie INT
AS
	INSERT INTO [Diffusion] ([DiffusionDate],[DiffusionTime],[AudioLang],[SubTitleLang],[Id_CinemaRoom],[Id_Movie])
		OUTPUT [inserted].[Id_Diffusion]
		VALUES (@diffusionDate, @diffusionTime, @audioLang, @subtitleLang, @id_cinemaRoom, @id_movie )
