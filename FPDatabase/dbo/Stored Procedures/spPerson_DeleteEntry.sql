CREATE PROCEDURE [dbo].[spPerson_DeleteEntry]
	@PersonId int
AS
begin
	delete
	from dbo.[PersonTable]
	where [PersonId] = @PersonId
end
