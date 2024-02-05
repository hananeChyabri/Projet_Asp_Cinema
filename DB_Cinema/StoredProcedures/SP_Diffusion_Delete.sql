CREATE PROCEDURE [dbo].[SP_Diffusion_Delete]
    @id INT
AS
BEGIN
    DELETE FROM Diffusion
        WHERE [Id_Diffusion] = @id;
END;
GO

