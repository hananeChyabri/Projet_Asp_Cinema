/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Language]
    VALUES  ('Original'),
            ('French');
GO


EXEC SP_CinemaPlace_Insert 'Pathé', 'Charleroi', 'Grand''Rue', '141/143';

EXEC SP_CinemaRoom_Insert 320, 1, 1200, 768, 0, 0, 1;
EXEC SP_CinemaRoom_Insert 450, 2, 1600, 900, 1, 1, 1;
EXEC SP_CinemaRoom_Insert 420, 3, 1200, 768, 1, 0, 1;

EXEC SP_Movie_Insert 'Jurassic Park', NULL, 1993, 'John Parker Hammond, le PDG de la puissante compagnie nommée InGen, parvient à donner vie à des dinosaures grâce à la génétique et décide de les utiliser dans le cadre d’un parc d’attractions qu’il compte ouvrir sur une île au large du Costa Rica.','jurassicpark.png', 128;

EXEC SP_Movie_Insert 'Matrix', NULL, 1999, 'Thomas A. Anderson, un jeune informaticien connu dans le monde du hacking sous le pseudonyme de Neo, est contacté via son ordinateur par ce qu’il pense être un groupe de hackers. Ils lui font découvrir que le monde dans lequel il vit n’est qu’un monde virtuel appelé la Matrice, à l’intérieur duquel les êtres humains sont gardés inconsciemment sous contrôle.','matrix.png', 136;

EXEC SP_Movie_Insert 'Star Wars', 'Episode IV - Un nouvel espoir', 1977, 'L’univers de Star Wars se déroule dans une galaxie qui est le théâtre d’affrontements entre les Chevaliers Jedi et les Seigneurs noirs des Sith, personnes sensibles à la Force, un champ énergétique mystérieux leur procurant des pouvoirs psychiques. Les Jedi maîtrisent le Côté lumineux de la Force, pouvoir bénéfique et défensif, pour maintenir la paix dans la galaxie. Les Sith utilisent le Côté obscur, pouvoir nuisible et destructeur, pour leurs usages personnels et pour dominer la galaxie.','starwars.png', 121;

EXEC SP_Movie_Insert 'Le Seigneur des anneaux', 'La Communauté de l''anneau', 2001, 'Dans le prologue, l''elfe Galadriel raconte l''histoire des anneaux magiques en Terre du Milieu. Les elfes en ont trois, les Nains sept et les Hommes, avides de pouvoir, en ont neuf. Mais Sauron a forgé l''Anneau unique pour diriger toute la Terre du Milieu. Ainsi, les elfes, les Nains et les Hommes s''allient pour combattre Sauron. Mais au cours de la bataille, le fils du roi des Hommes Isildur tranche les doigts de Sauron, dont l''un d''eux porte l''Anneau, faisant exploser le seigneur des ténèbres. Sauron est vaincu. Isildur, devenu roi, porte l''Anneau, mais celui-ci le trahit en s''échappant de son doigt pendant une embuscade, conduisant son hôte à la mort et disparaissant au fond du fleuve. 2500 ans plus tard, l''Anneau est repêché par hasard et appartiendra à la créature Gollum pendant 500 ans caché dans les Monts Brumeux, jusqu''à ce que l''Anneau tombe sur le hobbit Bilbon Sacquet qui le récupère.','lotr.png', 178;

DECLARE @today DATE = CONVERT(DATE,GETDATE());
DECLARE @now TIME = CONVERT(TIME,GETDATE());
DECLARE @next_time TIME = DATEADD(MINUTE,128,@now);

EXEC SP_Diffusion_Insert @today, @now, 'French', NULL, 2, 1;
EXEC SP_Diffusion_Insert @today, @now, 'Original', 'French', 3, 4;
EXEC SP_Diffusion_Insert @today, @now, 'French', NULL, 1, 2;
EXEC SP_Diffusion_Insert @today, @next_time, 'Original', 'French', 2, 3;
