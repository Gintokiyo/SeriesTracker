CREATE PROCEDURE [dbo].[spEpisode_GetAll]
AS
begin
	SELECT [EpisodeId], [EpisodeName], [EpisodeNumber], [EpisodeRating],
		   [EpisodeUrl], [EpisodeReleaseDate], [EpisodeSeriesId]
	from dbo.[EpisodeTable]
end
