CREATE TABLE [dbo].[SiteTable]
(
	[SiteId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SiteName] NVARCHAR(50) NULL, 
    [SiteUrl] NVARCHAR(50) NULL, 
    [SiteDescription] NVARCHAR(50) NULL, 
    [SiteDateWhenAdded] DATE NULL, 
    [SiteAccount] NVARCHAR(50) NULL
)
