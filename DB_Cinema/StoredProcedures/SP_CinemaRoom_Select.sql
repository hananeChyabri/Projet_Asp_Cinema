CREATE PROCEDURE [dbo].[SP_CinemaRoom_Select]
    @id INT
AS
BEGIN
    SELECT * FROM CinemaRoom
        WHERE [Id_CinemaRoom] = @id;
END;
GO

