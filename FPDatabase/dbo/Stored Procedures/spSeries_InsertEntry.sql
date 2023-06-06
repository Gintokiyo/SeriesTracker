CREATE PROCEDURE [dbo].[spSeries_InsertEntry]
	@SeriesName nvarchar(50),
	@SeriesOriginalName nvarchar(50),
	@SeriesDescription nvarchar(50),
	@SeriesRating real,
	@SeriesSeasonCount int,
	@SeriesEpisodeCount int,
	@SeriesLatestEpisode nvarchar(50),
	@SeriesPosterUrl nvarchar(50),
	@SeriesReleaseDate Date,
	@SeriesUpdateCycle int,
	@SeriesBackgroundUrl nvarchar(50),
	@SeriesOriginalLanguage nvarchar(50),
	@SeriesHomepage nvarchar(50)
AS
begin
	INSERT INTO dbo.[SeriesTable] (SeriesName, SeriesOriginalName, SeriesDescription, SeriesRating, 
									SeriesSeasonCount, SeriesEpisodeCount, SeriesLatestEpisode, 
									SeriesPosterUrl, SeriesReleaseDate, SeriesUpdateCycle,
									SeriesBackgroundUrl, SeriesOriginalLanguage, SeriesHomepage)
	VALUES (@SeriesName, @SeriesOriginalName, @SeriesDescription, @SeriesRating, @SeriesSeasonCount,
			@SeriesEpisodeCount, @SeriesLatestEpisode, @SeriesPosterUrl, @SeriesReleaseDate, @SeriesUpdateCycle,
			@SeriesBackgroundUrl, @SeriesOriginalLanguage, @SeriesHomepage)
end
