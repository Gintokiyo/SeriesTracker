CREATE PROCEDURE [dbo].[spPerson_UpdateEntry]
	@PersonId int,
	@PersonName nvarchar(50),
	@PersonAge int,
	@PersonCountryOfOrigin nvarchar(50)
AS
begin
	UPDATE dbo.[PersonTable]
	set PersonName = @PersonName, PersonAge = @PersonAge, PersonCountryOfOrigin = @PersonCountryOfOrigin
		where PersonId = @PersonId
end
