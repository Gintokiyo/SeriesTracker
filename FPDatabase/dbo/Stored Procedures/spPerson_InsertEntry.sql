CREATE PROCEDURE [dbo].[spPerson_InsertEntry]
	@PersonName nvarchar(50),
	@PersonAge int,
	@PersonCountryOfOrigin nvarchar(50)
AS
begin
	INSERT INTO dbo.[PersonTable] (PersonName, PersonAge, PersonCountryOfOrigin)
	VALUES (@PersonName, @PersonAge, @PersonCountryOfOrigin)
end
