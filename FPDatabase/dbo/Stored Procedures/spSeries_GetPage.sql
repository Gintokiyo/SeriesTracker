CREATE PROCEDURE [dbo].[spSeries_GetPage]
	@first int = 1
AS

WITH OrderedOrders AS  
(  
    SELECT [SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating], 
		   [SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL], 
		   [SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage], 
		   [SeriesHomepage],  
    ROW_NUMBER() OVER (ORDER BY [SeriesId]) AS RowNumber  
    FROM [dbo].SeriesTable   
)   
SELECT [SeriesId], [SeriesName], [SeriesOriginalName], [SeriesDescription], [SeriesRating], 
	   [SeriesSeasonCount], [SeriesEpisodeCount], [SeriesLatestEpisode], [SeriesPosterURL], 
	   [SeriesReleaseDate], [SeriesUpdateCycle], [SeriesBackgroundURL], [SeriesOriginalLanguage], 
	   [SeriesHomepage], RowNumber    
FROM OrderedOrders   
WHERE RowNumber BETWEEN @first AND (@first + 19);
RETURN 0
