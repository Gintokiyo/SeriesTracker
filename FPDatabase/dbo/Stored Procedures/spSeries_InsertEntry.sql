CREATE PROCEDURE [dbo].[spSeries_InsertEntry]
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
	INSERT INTO dbo.[SeriesTable] (SeriesName, SeriesOriginalName, SeriesDescription, SeriesRating, 
									SeriesSeasonCount, SeriesEpisodeCount, SeriesLatestEpisode, 
									SeriesUrl, SeriesReleaseDate, SeriesUpdateCycle)
	VALUES (@SeriesName, @SeriesOriginalName, @SeriesDescription, @SeriesRating, @SeriesSeasonCount,
			@SeriesEpisodeCount, @SeriesLatestEpisode, @SeriesUrl, @SeriesReleaseDate, @SeriesUpdateCycle)
end
