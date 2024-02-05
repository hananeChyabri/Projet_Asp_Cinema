CREATE PROCEDURE [dbo].[SP_CinemaRoom_Insert]
	@seatsCount INT,
	@number INT,
	@screenWidth INT,
	@screenHeight INT,
	@can3D BIT,
	@can4DX BIT,
	@id_cinemaPlace INT
AS
	INSERT INTO [CinemaRoom] ([SeatsCount],[Number],[ScreenWidth],[ScreenHeight],[Can3D],[Can4DX],[Id_CinemaPlace])
		OUTPUT [inserted].[Id_CinemaRoom]
		VALUES (@seatsCount,@number,@screenWidth,@screenHeight,@can3D,@can4DX,@id_cinemaPlace)
