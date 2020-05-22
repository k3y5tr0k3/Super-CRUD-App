/*
	Stored procedure to paginate Superhero table

	Parameters:
		pageNo - specify a page number 
		size   - specify a page size
		filter - specify a filter for results

	Returns:
		List of results modelled on input parameters
*/

/*
 *  DROP PROCEDURE sp_SelectPageOfSuperheros
 */

CREATE PROCEDURE sp_SelectPageOfSuperheros(

	@pageNo int = 1,
	@pageSize int = 25,
	@filter varchar(50) = null

) AS

DECLARE @totalRecords int;
SELECT @totalRecords = COUNT(*) FROM [dbo].[Superhero];

DECLARE @totalPages int = @totalRecords / @pageSize + 1;

DECLARE @offset int = (@pageNo - 1) * @pageSize;
DECLARE @upperLimit int = @offset + @pageSize;

IF (@pageNo > 0 AND 
	@pageNo <= @totalPages
)
	BEGIN
	 
		SELECT
			*
		FROM(
			SELECT
				ROW_NUMBER() OVER (ORDER BY [SuperheroID]) AS [RowNum],
				[SuperheroID],
				[Name]
			FROM
				[dbo].[Superhero]
		) AS RowConstrainedResult

		WHERE
			[RowNum] > @offset AND
			[RowNum] < @upperLimit

	END

RETURN

GO;
