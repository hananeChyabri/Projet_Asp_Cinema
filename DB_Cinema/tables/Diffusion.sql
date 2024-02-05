CREATE TABLE [dbo].[Diffusion]
(
	[Id_Diffusion] INT IDENTITY NOT NULL PRIMARY KEY,
	[DiffusionDate] DATE NOT NULL,
	[DiffusionTime] TIME NOT NULL,
	[AudioLang] Nvarchar(50) NOT NULL, 
	[SubTitlelang] Nvarchar(50) NULL, 
    [Id_CinemaRoom] INT NOT NULL, 
    [Id_Movie] INT NOT NULL, 
    CONSTRAINT [FK_Diffusion_CinemaRoom] FOREIGN KEY ([Id_CinemaRoom]) REFERENCES [CinemaRoom]([Id_CinemaRoom]),
	CONSTRAINT [FK_Diffusion_Movie] FOREIGN KEY ([Id_Movie]) REFERENCES [Movie]([Id_Movie]),
	CONSTRAINT [FK_Audio_Langue] FOREIGN KEY ([AudioLang]) REFERENCES [Langue]([Language]),
	CONSTRAINT [FK_Subtitle_Langue] FOREIGN KEY ([SubTitlelang]) REFERENCES [Langue]([Language]), 

)
