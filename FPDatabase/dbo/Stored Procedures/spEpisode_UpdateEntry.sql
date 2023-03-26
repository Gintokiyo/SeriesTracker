CREATE PROCEDURE [dbo].[spEpisode_UpdateEntry]
	@EpisodeId int,
	@EpisodeName nvarchar(50),
	@EpisodeNumber nvarchar(50),
	@EpisodeRating real,
	@EpisodeUrl nvarchar(50),
	@EpisodeReleaseDate nvarchar(50),
	@EpisodeSeriesId int
AS
begin
	UPDATE dbo.[EpisodeTable]
	set EpisodeName = @EpisodeName, EpisodeNumber = @EpisodeNumber, EpisodeRating = @EpisodeRating,
		EpisodeUrl = @EpisodeUrl, EpisodeReleaseDate = @EpisodeReleaseDate, EpisodeSeriesId = @EpisodeSeriesId
		where EpisodeId = @EpisodeId
end
