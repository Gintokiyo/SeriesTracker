CREATE PROCEDURE [dbo].[spSite_UpdateEntry]
	@SiteId int,
	@SiteName nvarchar(50),
	@SiteUrl nvarchar(50),
	@SiteDescription nvarchar(50),
	@SiteDateWhenAdded date
AS
begin
	UPDATE dbo.[SiteTable]
	set SiteName = @SiteName, SiteUrl = @Siteurl,
		SiteDescription = @SiteDescription, SiteDateWhenAdded = @SiteDateWhenAdded
		where SiteId = @SiteId
end
