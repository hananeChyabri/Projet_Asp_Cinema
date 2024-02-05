CREATE PROCEDURE [dbo].[SP_CinemaRoom_Update]
    @id INT,
 	@sitsCout INT,
	@Number INT,
	@ScreenHeight INT,
	@Can3D BIT,
	@Can4D BIT,
	@Id_CinemaPlace INT 
AS
    UPDATE CinemaRoom
    SET 
        [SitsCout] = @sitsCout,
        [Number] = @Number,
        [ScreenHeight] = @ScreenHeight,
        [Can3D] = @Can3D,
        [Can4D] = @Can4D,
        [Id_CinemaPlace] = @Id_CinemaPlace
    WHERE 
        [Id_CinemaRoom] = @id;

