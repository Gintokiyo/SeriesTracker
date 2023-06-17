CREATE PROCEDURE [dbo].[spSeries_GetEntry]
	@SeriesId int
AS
begin
	SELECT	[SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating],
			[SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL],
			[SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage],
			[SeriesHomepage], [SeriesExternalId]
	from dbo.[SeriesTable]
	where SeriesId = @SeriesId
end
