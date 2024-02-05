CREATE PROCEDURE [dbo].[SP_Diffusion_Delete]
	@id_diffusion INT
AS
	DELETE FROM [Diffusion]
		WHERE [Id_Diffusion] = @id_diffusion
