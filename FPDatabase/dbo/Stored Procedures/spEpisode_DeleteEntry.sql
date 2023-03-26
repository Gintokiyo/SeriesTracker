CREATE PROCEDURE [dbo].[spEpisode_DeleteEntry]
	@EpisodeId int
AS
begin
	delete
	from dbo.[EpisodeTable]
	where [EpisodeId] = @EpisodeId
end
