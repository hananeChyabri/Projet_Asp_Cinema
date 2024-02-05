CREATE TABLE [dbo].[Movie]
(
	[Id_Movie] INT IDENTITY NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(64) NOT NULL,
	[SubTitle] NVARCHAR(64) NULL,
	[ReleaseYear] SMALLINT NOT NULL,
	[Synopsis] NVARCHAR(MAX) NOT NULL,
	[PosterUrl] NVARCHAR(256) NOT NULL,
	[Duration] INT NOT NULL, 
    CONSTRAINT [CK_Movie_ReleaseYear] CHECK ([ReleaseYear] BETWEEN 1800 AND YEAR(GETDATE())),
    CONSTRAINT [CK_Movie_Duration] CHECK ([Duration] > 0), 
    CONSTRAINT [UK_Movie_Title] UNIQUE ([Title], [SubTitle], [ReleaseYear])
)
