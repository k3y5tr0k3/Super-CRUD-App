/*
	Some dummy data used for testing and feature development
*/

USE SuperRegistry;


INSERT INTO dbo.Affinity (Type)
VALUES('Good'),
	  ('Bad'),
	  ('Anti-hero')


INSERT INTO dbo.Superhero (AffinityID, Name)
VALUES(1, 'Ironman'),
	  (2,'Captain America')
	 

INSERT INTO dbo.Ability(Name, Description)
VALUES('X ray vision','Can see through stuff'),
	('Super Strength','Can lift heavy stuff')


INSERT INTO dbo.Region(Name)
VALUES('CANADA'),
	  ('MURICUH')


Insert INTO dbo.SuperheroRegion (SuperheroID, RegionID)
VALUES (1, 1),
	   (2, 1)


INSERT INTO dbo.SuperheroAbility (SuperheroID, AbilityID)
VALUES (1,1),
	   (2,2)


INSERT INTO dbo.Background (SuperheroID)
VALUES (1),
       (2);


INSERT INTO dbo.Origin (Type)
VALUES ('Mutation'),
       ('Spider bite');


INSERT INTO dbo.BackgroundOrigin (BackgroundID, OriginID)
VALUES (1,1),
       (2,2);


INSERT INTO dbo.Alias (BackgroundID, Firstname, Lastname)
VALUES (1, 'Tony', 'Stark'),
	   (2, 'Peter', 'Parker')

