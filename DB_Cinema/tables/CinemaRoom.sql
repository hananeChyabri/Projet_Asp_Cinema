CREATE TABLE [dbo].[CinemaRoom]
(
	
	[Id_CinemaRoom] INT IDENTITY NOT NULL PRIMARY KEY,
	[SitsCout] INT NOT NULL,
	[Number] INT NOT NULL,
	[ScreenHeight] INT NOT NULL, 
    [Can3D] BIT NOT NULL, 
    [Can4D] BIT NOT NULL, 
    [Id_CinemaPlace] INT NOT NULL, 
    CONSTRAINT [FK_CinemaRoom_CinemaPlace] FOREIGN KEY ([Id_CinemaPlace]) REFERENCES [CinemaPlace]([Id_CinemaPlace]),
)
