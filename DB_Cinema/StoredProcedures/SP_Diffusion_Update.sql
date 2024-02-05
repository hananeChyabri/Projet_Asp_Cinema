CREATE PROCEDURE [dbo].[SP_Diffusion_Update]
    @id INT,
 	@diffusionDate DATE,
	@diffusionTime TIME,
	@audioLang Nvarchar(50), 
	@subTitlelang Nvarchar(50), 
    @id_CinemaRoom INT, 
    @id_Movie INT 
AS
    UPDATE Diffusion
    SET 
        [DiffusionDate] = @diffusionDate,
        [DiffusionTime] = @diffusionTime,
        [AudioLang] = @audioLang,
        [SubTitlelang] = @subTitlelang,
        [Id_CinemaRoom] = @id_CinemaRoom,
        [Id_Movie] = @id_Movie
    WHERE 
        [Id_CinemaRoom] = @id;
