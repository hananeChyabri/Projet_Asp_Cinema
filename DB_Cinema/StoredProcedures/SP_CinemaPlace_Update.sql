CREATE PROCEDURE [dbo].[SP_CinemaPlace_Update]
    @id INT,
    @name NVARCHAR(64),
    @city NVARCHAR(64),
    @street NVARCHAR(64),
    @number NVARCHAR(128)
AS
    UPDATE CinemaPlace
    SET 
        [Name] = @name,
        [City] = @city,
        [Street] = @street,
        [Number] = @number
    WHERE 
        [Id_CinemaPlace] = @id;

