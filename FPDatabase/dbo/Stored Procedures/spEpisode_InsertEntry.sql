CREATE PROCEDURE [dbo].[spEpisode_InsertEntry]
	@EpisodeName nvarchar(50),
	@EpisodeNumber nvarchar(50),
	@EpisodeRating real,
	@EpisodeUrl nvarchar(50),
	@EpisodeReleaseDate nvarchar(50),
	@EpisodeSeriesId int
AS
begin
	INSERT INTO dbo.[EpisodeTable] (EpisodeName, EpisodeNumber, EpisodeRating, EpisodeUrl,
									EpisodeReleaseDate, EpisodeSeriesId)
	VALUES (@EpisodeName, @EpisodeNumber, @EpisodeRating, @EpisodeUrl, @EpisodeReleaseDate, @EpisodeSeriesId)
end
