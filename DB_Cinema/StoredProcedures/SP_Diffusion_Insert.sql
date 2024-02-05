CREATE PROCEDURE [dbo].[SP_Diffusion_Insert]

	@diffusionDate DATE,
	@diffusionTime TIME,
	@audioLang Nvarchar(50), 
	@subTitlelang Nvarchar(50), 
    @id_CinemaRoom INT, 
    @id_Movie INT
AS
	INSERT INTO [Diffusion] ([DiffusionDate],[DiffusionTime],[AudioLang],[SubTitlelang],[Id_CinemaRoom],[Id_Movie])
	OUTPUT [inserted].[Id_Diffusion]
	VALUES (@diffusionDate,@diffusionTime,@audioLang,@subTitlelang,@id_CinemaRoom,@id_Movie)
RETURN 
