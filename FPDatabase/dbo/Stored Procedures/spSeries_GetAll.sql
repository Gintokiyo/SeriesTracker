CREATE PROCEDURE [dbo].[spSeries_GetAll]
AS
begin
	SELECT	[SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating],
			[SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesUrl],
			[SeriesReleaseDate], [SeriesUpdateCycle]
	from dbo.[SeriesTable]
end