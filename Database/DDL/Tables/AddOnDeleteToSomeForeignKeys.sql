/*
 *    When a row of a table is deleted, any child tables that reference that table 
 *    with a foreign key must have the appropriate ON DELETE functionality
 *
 */

 USE SuperRegistry;


 /* 
  *    SuperheroAbility Table 
  */
 ALTER TABLE [dbo].[SuperheroAbility]
	DROP CONSTRAINT [FK_SuperheroAbility_Superhero_ID]

ALTER TABLE [dbo].[SuperheroAbility]
	WITH CHECK ADD CONSTRAINT [FK_SuperheroAbility_Superhero_ID]
	FOREIGN KEY(SuperheroID) 
	REFERENCES [Superhero](SuperheroID)
	ON DELETE CASCADE


/* 
 *    SuperheroRegion Table 
 */
 ALTER TABLE [dbo].[SuperheroRegion]
	DROP CONSTRAINT [FK_SuperheroRegion_Superhero_ID]

ALTER TABLE [dbo].[SuperheroRegion]
	WITH CHECK ADD CONSTRAINT [FK_SuperheroRegion_Superhero_ID]
	FOREIGN KEY (SuperheroID)
	REFERENCES [Superhero](SuperheroID)
	ON DELETE CASCADE


/* 
 *    Background Table 
 */
 ALTER TABLE [dbo].[Background]
	DROP CONSTRAINT [FK_Background_Superhero_ID]

ALTER TABLE [dbo].[Background]
	WITH CHECK ADD CONSTRAINT [FK_Background_Superhero_ID]
	FOREIGN KEY (SuperheroID)
	REFERENCES [Superhero](SuperheroID)
	ON DELETE CASCADE


/* 
 *    BackgroundOrigin Table 
 */
 ALTER TABLE [dbo].[BackgroundOrigin]
	DROP CONSTRAINT [FK_BackgroundOrigin_Background_ID]

ALTER TABLE [dbo].[BackgroundOrigin]
	WITH CHECK ADD CONSTRAINT [FK_BackgroundOrigin_Background_ID]
	FOREIGN KEY (BackgroundID)
	REFERENCES [Background](BackgroundID)
	ON DELETE CASCADE


/* 
 *    Alias Table 
 */
 ALTER TABLE [dbo].[Alias]
	DROP CONSTRAINT [FK_Alias_Background_ID]

ALTER TABLE [dbo].[Alias]
	WITH CHECK ADD CONSTRAINT [FK_Alias_Background_ID]
	FOREIGN KEY (BackgroundID)
	REFERENCES [Background](BackgroundID)
	ON DELETE CASCADE
