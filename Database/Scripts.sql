USE SuperRegistry;

/* Affinity lookup table */
INSERT INTO dbo.Affinity (Type)
VALUES('Good'),
	  ('Bad'),
	  ('Anti-hero')


SELECT * FROM dbo.Affinity;

DROP TABLE IF EXISTS dbo.Superhero;

INSERT INTO dbo.Superhero (AffinityID, Name)
VALUES(1, 'Ironman'),
	  (2,'Captain America')
	  
SELECT * FROM Ability;

INSERT INTO dbo.Ability(Name, Description)
VALUES('X ray vision','Can see through stuff'),
	('Super Strength','Can lift heavy stuff'),
	('Flight', 'Can fly')

Insert INTO dbo.SuperheroRegion (SuperheroID, RegionID)
VALUES (5, 1),
	   (6, 1)

INSERT INTO dbo.SuperheroAbility (SuperheroID, AbilityID)
VALUES (5,1),
	   (6,1),
	   (6,2),
	   (5,3)

INSERT INTO dbo.Background (SuperheroID)
VALUES (5),
       (6);

INSERT INTO dbo.Origin (Type)
VALUES ('Mutation'),
       ('Spider bite');

INSERT INTO dbo.BackgroundOrigin (BackgroundID, OriginID)
VALUES (1,1),
       (2,2);

INSERT INTO dbo.Alias (BackgroundID, Firstname, Lastname)
VALUES (1, 'Tony', 'Stark'),
	   (2, 'Peter', 'Parker')

SELECT * FROM Background;

