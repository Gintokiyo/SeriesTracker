CREATE PROCEDURE [dbo].[spSite_GetAll]
AS
begin
	SELECT SiteId, SiteName, SiteUrl, SiteDescription, SiteDateWhenAdded
	from dbo.SiteTable
end
