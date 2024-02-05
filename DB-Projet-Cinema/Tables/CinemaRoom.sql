CREATE TABLE [dbo].[CinemaRoom]
(
	[Id_CinemaRoom] INT IDENTITY NOT NULL PRIMARY KEY,
	[SeatsCount] INT NOT NULL,
	[Number] INT NOT NULL,
	[ScreenWidth] INT NOT NULL,
	[ScreenHeight] INT NOT NULL,
	[Can3D] BIT NOT NULL,
	[Can4DX] BIT NOT NULL,
	[Id_CinemaPlace] INT NOT NULL,
	CONSTRAINT [FK_CinemaRoom_CinemaPlace] FOREIGN KEY ([Id_CinemaPlace]) REFERENCES [CinemaPlace]([Id_CinemaPlace]), 
    CONSTRAINT [CK_CinemaRoom_SeatsCount] CHECK ([SeatsCount] > 0),
    CONSTRAINT [CK_CinemaRoom_Ratio] CHECK ([ScreenWidth] > [ScreenHeight] AND [ScreenWidth] > 0 AND [ScreenHeight] > 0)

)
