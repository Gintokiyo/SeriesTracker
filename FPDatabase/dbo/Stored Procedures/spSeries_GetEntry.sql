CREATE PROCEDURE [dbo].[spSeries_GetEntry]
	@SeriesId int
AS
begin
	SELECT	[SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating],
			[SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesUrl],
			[SeriesReleaseDate], [SeriesUpdateCycle]
	from dbo.[SeriesTable]
	where SeriesId = @SeriesId
end
