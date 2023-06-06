CREATE PROCEDURE [dbo].[spEpisode_GetEntry]
	@EpisodeId int
AS
begin
	SELECT [EpisodeId], [EpisodeName], [EpisodeNumber], [EpisodeRating], 
		   [EpisodeUrl], [EpisodeReleaseDate], [EpisodeSeriesId]
	from dbo.[EpisodeTable]
	where EpisodeId = @EpisodeId
end
