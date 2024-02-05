CREATE PROCEDURE [dbo].[SP_CinemaPlace_GetAll]
AS
	SELECT	[Id_CinemaPlace],
			[Name],
			[City],
			[Street],
			[Number]
		FROM [CinemaPlace]
