/*
	Stored procedure to paginate Superhero table

	Parameters:
		id - specify a page number 

	Returns:
		All the information about the specified superhero 
*/

/*
 *  DROP PROCEDURE sp_GetSuperheroBySuperheroID
 */

 

 CREATE PROCEDURE sp_DeleteSuperheroBySuperheroID(
	
	@id int

) AS
	DELETE FROM [dbo].[Superhero] WHERE SuperheroID = @id


