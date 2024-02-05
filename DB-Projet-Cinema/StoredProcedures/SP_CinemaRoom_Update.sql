CREATE PROCEDURE [dbo].[SP_CinemaRoom_Update]
	@id_cinemaroom INT,
	@seatsCount INT,
	@number INT,
	@screenWidth INT,
	@screenHeight INT,
	@can3D BIT,
	@can4DX BIT,
	@id_cinemaPlace INT
AS
	UPDATE [CinemaRoom] 
		SET [Number] = @number ,
			[SeatsCount] = @seatsCount ,
			[ScreenWidth] = @screenWidth ,
			[ScreenHeight] = @screenHeight ,
			[Can3D] = @can3D ,
			[Can4DX] = @can4DX ,
			[Id_CinemaPlace] = @id_cinemaPlace
		WHERE [Id_CinemaRoom] = @id_cinemaroom