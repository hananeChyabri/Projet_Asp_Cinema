CREATE PROCEDURE [dbo].[SP_CinemaPlace_Update]
	@id_cinemaplace INT,
	@name NVARCHAR(64),
	@city NVARCHAR(64),
	@street NVARCHAR(128),
	@number NVARCHAR(8)
AS
	UPDATE [CinemaPlace] 
		SET [Name] = @name ,
			[City] = @city ,
			[Street] = @street ,
			[Number] = @number
		WHERE [Id_CinemaPlace] = @id_cinemaplace