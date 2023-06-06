CREATE PROCEDURE [dbo].[spSeries_UpdateEntry]
	@SeriesId int,
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
	UPDATE dbo.[SeriesTable]
	set SeriesName = @SeriesName, SeriesOriginalName = @SeriesOriginalName, SeriesDescription = @SeriesDescription,
		SeriesRating = @SeriesRating, SeriesSeasonCount = @SeriesSeasonCount, SeriesEpisodeCount = @SeriesEpisodeCount,
		SeriesLatestEpisode = @SeriesLatestEpisode, SeriesPosterUrl = @SeriesPosterUrl, SeriesReleaseDate = @SeriesReleaseDate,
		SeriesUpdateCycle = @SeriesUpdateCycle, SeriesBackgroundUrl = @SeriesBackgroundUrl,
		SeriesOriginalLanguage = @SeriesOriginalLanguage, SeriesHomepage = @SeriesHomepage
		where SeriesId = @SeriesId
end