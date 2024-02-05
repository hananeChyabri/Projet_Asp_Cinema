CREATE PROCEDURE [dbo].[SP_CinemaPlace_Delete]
    @id INT
AS
BEGIN
    DELETE FROM CinemaPlace
        WHERE [Id_CinemaPlace] = @id;
END;
GO

