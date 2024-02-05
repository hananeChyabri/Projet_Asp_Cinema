CREATE PROCEDURE [dbo].[SP_CinemaPlace_GetById]
	@id_cinemaplace INT
AS
	SELECT	[Id_CinemaPlace],
			[Name],
			[City],
			[Street],
			[Number]
		FROM [CinemaPlace]
		WHERE [Id_CinemaPlace] = @id_cinemaplace
