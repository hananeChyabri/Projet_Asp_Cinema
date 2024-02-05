CREATE PROCEDURE [dbo].[SP_CinemaPlace_Select]
    @street Nvarchar(64)
AS
BEGIN
    SELECT * FROM CinemaPlace
        WHERE [Street] = @street;
END;
GO

