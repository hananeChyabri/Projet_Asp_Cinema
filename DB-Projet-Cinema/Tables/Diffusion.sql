CREATE TABLE [dbo].[Diffusion]
(
	[Id_Diffusion] INT IDENTITY NOT NULL PRIMARY KEY,
	[DiffusionDate] DATE NOT NULL,
	[DiffusionTime] TIME NOT NULL,
	[AudioLang] VARCHAR(16) NOT NULL,
	[SubTitleLang] VARCHAR(16),
	[Id_CinemaRoom] INT NOT NULL,
	[Id_Movie] INT NOT NULL, 
    CONSTRAINT [FK_Diffusion_AudioLanguage] FOREIGN KEY ([AudioLang]) REFERENCES [Language]([Language]),
    CONSTRAINT [FK_Diffusion_SubTitleLanguage] FOREIGN KEY ([SubTitleLang]) REFERENCES [Language]([Language]),
    CONSTRAINT [FK_Diffusion_Movie] FOREIGN KEY ([Id_Movie]) REFERENCES [Movie]([Id_Movie]),
    CONSTRAINT [FK_Diffusion_CinemaRoom] FOREIGN KEY ([Id_CinemaRoom]) REFERENCES [CinemaRoom]([Id_CinemaRoom])
)
