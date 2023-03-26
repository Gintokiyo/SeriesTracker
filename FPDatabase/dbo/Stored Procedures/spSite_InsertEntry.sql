CREATE PROCEDURE [dbo].[spSite_InsertEntry]
	@SiteName nvarchar(50),
	@SiteUrl nvarchar(50),
	@SiteDescription nvarchar(50),
	@SiteDateWhenAdded date
AS
begin
	INSERT INTO dbo.[SiteTable] (SiteName, SiteUrl, SiteDescription, SiteDateWhenAdded)
	VALUES (@SiteName, @SiteUrl, @SiteDescription, @SiteDateWhenAdded)
end
