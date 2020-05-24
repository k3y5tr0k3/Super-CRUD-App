/*
	Stored procedure to get superhero details

	Parameters:
		id - SuperheroID

	Returns:
		All the information about the specified superhero
*/

/*
 *  DROP PROCEDURE sp_SelectSuperheroDetailsBySuperheroID
 */



 CREATE PROCEDURE sp_SelectSuperheroDetailsBySuperheroID(
	
	@id int
 
 ) AS


 SELECT DISTINCT
	hero.[SuperheroID],
	hero.[Name],
	affinity.Type as [Affinity],
	origin.Type as [Origin],
	region.Name as [Region_Name],
	ability.Name as [Ability_Name],
	ability.Description as [Ability_Description],
	[FirstName],
	[LastName]

FROM Superhero AS hero

	/* Affinty */
	INNER JOIN
	Affinity as affinity
		ON hero.AffinityID = affinity.AffinityID


	/* Region */
	LEFT JOIN 
	SuperheroRegion as sr
		ON hero.SuperheroID = sr.SuperheroID
	LEFT JOIN
	Region as region
		ON sr.RegionID = region.RegionID


	/* Ability */
	LEFT JOIN
	SuperheroAbility as sa
		ON hero.SuperheroID = sa.SuperheroID
	LEFT JOIN
	Ability as ability
		ON sa.AbilityID = ability.AbilityID


	/* BackgroundID */
	INNER JOIN
	Background as bg
		ON hero.SuperheroID = bg.SuperheroID


	/* Origin */
	LEFT JOIN
	BackgroundOrigin as bo
		ON bg.BackgroundID = bo.BackgroundID
	LEFT JOIN
	Origin as origin
		ON bo.OriginID = origin.OriginID


	/* Alias */
	INNER JOIN
	Alias as alias
		ON bg.BackgroundID = alias.BackgroundID

	
WHERE hero.SuperheroID = 2;

Return;
