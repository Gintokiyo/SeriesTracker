CREATE PROCEDURE [dbo].[spSeries_DeleteEntry]
	@SeriesId int
AS
begin
	delete
	from dbo.[SeriesTable]
	where [SeriesId] = @SeriesId
end
