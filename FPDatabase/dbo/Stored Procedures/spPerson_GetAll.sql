CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS
begin
	SELECT [PersonId], [PersonName], [PersonAge], [PersonCountryOfOrigin]
	from dbo.[PersonTable]
end
