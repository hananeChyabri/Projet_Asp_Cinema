CREATE PROCEDURE [dbo].[SP_CinemaRoom_Delete]
    @id INT
AS
BEGIN
    DELETE FROM CinemaRoom
        WHERE [Id_CinemaRoom] = @id;
END;
GO

