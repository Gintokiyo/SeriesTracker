CREATE PROCEDURE [dbo].[spSite_DeleteEntry]
	@SiteId int
AS
begin
	delete
	from dbo.[SiteTable]
	where [SiteId] = @SiteId
end
