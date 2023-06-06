CREATE PROCEDURE [dbo].[spSeries_GetEntry]
	@SeriesId int
AS
begin
	SELECT	[SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating],
			[SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL],
			[SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage],
			[SeriesHomepage]
	from dbo.[SeriesTable]
	where SeriesId = @SeriesId
end
