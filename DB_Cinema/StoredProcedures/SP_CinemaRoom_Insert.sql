CREATE PROCEDURE [dbo].[SP_CinemaRoom_Insert]
	@sitsCout INT,
	@number INT,
	@screenHeight INT,
	@can3D BIT,
	@can4D BIT,
	@id_CinemaPlace INT 
AS
	INSERT INTO [CinemaRoom] ([SitsCout],[Number],[ScreenHeight],[Can3D],[Can4D],[Id_CinemaPlace])
	OUTPUT [inserted].[Id_CinemaRoom]
	VALUES (@sitsCout,@number,@screenHeight,@can3D,@can4D,@id_CinemaPlace)
RETURN
