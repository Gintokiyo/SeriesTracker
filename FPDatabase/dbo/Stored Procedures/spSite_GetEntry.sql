CREATE PROCEDURE [dbo].[spSite_GetEntry]
	@SiteId int
AS
begin
	SELECT [SiteName], [SiteUrl], [SiteDescription], [SiteDateWhenAdded]
	from dbo.[SiteTable]
	where SiteId = @SiteId
end
