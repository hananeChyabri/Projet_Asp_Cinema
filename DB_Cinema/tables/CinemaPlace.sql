CREATE TABLE [dbo].[CinemaPlace]
(
	[Id_CinemaPlace] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] Nvarchar(64) NOT NULL,
	[City] Nvarchar(64) NOT NULL,
	[Street] Nvarchar(128) NOT NULL,
	[Number] Nvarchar(8) NOT NULL, 
)
