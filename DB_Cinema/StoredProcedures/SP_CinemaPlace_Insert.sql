CREATE PROCEDURE [dbo].[SP_CinemaPlace_Insert]
    @name NVARCHAR(64),
    @city NVARCHAR(64),
    @street NVARCHAR(64),
    @number NVARCHAR(128)
AS
	INSERT INTO [CinemaPlace] ([Name],[City],[Street],[Number])
	OUTPUT [inserted].[Id_CinemaPlace]
	VALUES (@name,@city,@street,@number)
RETURN
