CREATE PROCEDURE [dbo].[SP_ListingDiffusionCinema]
   
      @street Nvarchar(64)
AS
BEGIN
    SELECT * FROM Diffusion df
    JOIN cinemaRoom cr ON df.Id_Diffusion = cr.Id_CinemaPlace
  
END;


