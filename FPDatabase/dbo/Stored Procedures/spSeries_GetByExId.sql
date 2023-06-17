CREATE PROCEDURE [dbo].[spSeries_GetByExId]
	@externalId int = 0
AS
	SELECT [SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating], 
		   [SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL], 
		   [SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage], 
		   [SeriesHomepage], [SeriesExternalId] 
	FROM [dbo].SeriesTable
	WHERE SeriesExternalId = @externalId
RETURN 0
