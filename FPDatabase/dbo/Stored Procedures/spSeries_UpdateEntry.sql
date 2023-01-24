CREATE PROCEDURE [dbo].[spSeries_UpdateEntry]
	@SeriesId int,
	@SeriesName nvarchar(50),
	@SeriesOriginalName nvarchar(50),
	@SeriesDescription nvarchar(50),
	@SeriesRating real,
	@SeriesSeasonCount int,
	@SeriesEpisodeCount int,
	@SeriesLatestEpisode nvarchar(50),
	@SeriesUrl nvarchar(50),
	@SeriesReleaseDate nvarchar(50),
	@SeriesUpdateCycle int
AS
begin
	UPDATE dbo.[SeriesTable]
	set SeriesName = @SeriesName, SeriesOriginalName = @SeriesOriginalName, SeriesDescription = @SeriesDescription,
		SeriesRating = @SeriesRating, SeriesSeasonCount = @SeriesSeasonCount, SeriesEpisodeCount = @SeriesEpisodeCount,
		SeriesLatestEpisode = @SeriesLatestEpisode, SeriesUrl = @SeriesUrl, SeriesReleaseDate = @SeriesReleaseDate,
		SeriesUpdateCycle = @SeriesUpdateCycle
		where SeriesId = @SeriesId
end