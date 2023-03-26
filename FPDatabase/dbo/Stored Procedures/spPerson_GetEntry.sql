CREATE PROCEDURE [dbo].[spPerson_GetEntry]
	@PersonId int
AS
begin
	SELECT [PersonId], [PersonName], [PersonAge], [PersonCountryOfOrigin]
	from dbo.[PersonTable]
	where PersonId = @PersonId
end
