CREATE TABLE [dbo].[Movie]
(
	[Id_Movie] INT NOT NULL PRIMARY KEY IDENTITY,
	[Tiltle] Nvarchar(64) NOT NULL,
	[SubTitle] Nvarchar(64) NULL,
	[ReleaseYear] SMALLINT NOT NULL, 
    [Synopsis] Nvarchar(Max) NOT NULL, 
    [PosterUrl] Nvarchar(256) NOT NULL, 
    [Duration] INT NOT NULL
)
