CREATE DATABASE SuperRegistry;

USE SuperRegistry;

CREATE TABLE [Affinity](
	[AffinityID] int PRIMARY KEY IDENTITY(1, 1),
	[Type] varchar(80) UNIQUE
);
CREATE TABLE [Superhero](
	[SuperheroID] int PRIMARY KEY IDENTITY(1, 1),
	[AffinityID] int,
	[Name] varchar(120) UNIQUE,
	CONSTRAINT FK_Superhero_Affinity_ID 
	FOREIGN KEY(AffinityID) REFERENCES [Affinity](AffinityID)
);
CREATE TABLE [Ability](
	[AbilityID] int PRIMARY KEY IDENTITY(1, 1),
	[Name] varchar(150) UNIQUE,
	[Description] varchar(MAX)
);
CREATE TABLE [SuperheroAbility](
	[SuperheroID] int,
	[AbilityID] int,
	CONSTRAINT FK_SuperheroAbility_Superhero_ID 
	FOREIGN KEY(SuperheroID) REFERENCES [Superhero](SuperheroID),
	CONSTRAINT FK_SuperheroAbility_Ability_ID
	FOREIGN KEY(AbilityID) REFERENCES [Ability](AbilityID),
	
);
CREATE TABLE [Region](
	[RegionID] int PRIMARY KEY IDENTITY(1, 1),
	[Name] varchar(MAX)
);
CREATE TABLE [SuperheroRegion](
	[SuperheroID] int,
	[RegionID] int,
	CONSTRAINT FK_SuperheroRegion_Superhero_ID 
	FOREIGN KEY(SuperheroID) REFERENCES [Superhero](SuperheroID),
	CONSTRAINT FK_SuperheroRegion_Region_ID
	FOREIGN KEY(RegionID) REFERENCES [Region](RegionID)
);
CREATE TABLE [Background](
	[BackgroundID] int PRIMARY KEY IDENTITY(1, 1),
	[SuperheroID] int,
	CONSTRAINT FK_Background_Superhero_ID
	FOREIGN KEY(SuperheroID) REFERENCES [Superhero](SuperheroID)
);
CREATE TABLE [Origin](
	[OriginID] int PRIMARY KEY IDENTITY(1, 1),
	[Type] varchar(255) UNIQUE
);
CREATE TABLE [BackgroundOrigin](
	[BackgroundID] int,
	[OriginID] int,
	CONSTRAINT FK_BackgroundOrigin_Background_ID
	FOREIGN KEY(BackgroundID) REFERENCES [Background](BackgroundID),
	CONSTRAINT FK_BackgroundOrigin_Origin_ID
	FOREIGN KEY(OriginID) REFERENCES [Origin](OriginID)
);
CREATE TABLE [Alias](
	[AliasID] int PRIMARY KEY IDENTITY(1, 1),
	[BackgroundID] int,
	[Firstname] varchar(120),
	[Lastname] varchar(120),
	CONSTRAINT FK_Alias_Background_ID
	FOREIGN KEY(BackgroundID) REFERENCES [Background](BackgroundID)
);

-- Use the below to drop if needed.
/*
DROP TABLE IF EXISTS [BackgroundOrigin];
DROP TABLE IF EXISTS [Origin];
DROP TABLE IF EXISTS [SuperheroRegion];
DROP TABLE IF EXISTS [Region];
DROP TABLE IF EXISTS [SuperheroAbility];
DROP TABLE IF EXISTS [Ability];
DROP TABLE IF EXISTS [Alias];
DROP TABLE IF EXISTS [Background];
DROP TABLE IF EXISTS [Superhero];
DROP TABLE IF EXISTS [Affinity];
*/






