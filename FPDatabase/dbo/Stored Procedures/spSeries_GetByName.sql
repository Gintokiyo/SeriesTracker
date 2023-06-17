CREATE PROCEDURE [dbo].[spSeries_GetByName]
	@search nvarchar(100) = ' '
AS
	SELECT [SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating], 
		   [SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL], 
		   [SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage], 
		   [SeriesHomepage], [SeriesExternalId] 
	FROM [dbo].SeriesTable
	WHERE [SeriesName] LIKE '%' + @search + '%' OR [SeriesOriginalName] LIKE '%' + @search + '%'
RETURN 0
