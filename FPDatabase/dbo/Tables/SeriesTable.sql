CREATE TABLE [dbo].[SeriesTable]
(
	[SeriesId] INT NOT NULL  IDENTITY, 
    [SeriesName] NVARCHAR(50) NULL, 
    [SeriesOriginalName] NVARCHAR(50) NULL, 
    [SeriesDescription] NVARCHAR(50) NULL, 
    [SeriesRating] REAL NOT NULL DEFAULT 0.0, 
    [SeriesSeasonCount] INT NOT NULL DEFAULT 0, 
    [SeriesEpisodeCount] INT NOT NULL DEFAULT 0, 
    [SeriesLatestEpisode] NVARCHAR(50) NULL, 
    [SeriesUrl] NVARCHAR(50) NULL, 
    [SeriesReleaseDate] NVARCHAR(50) NULL, 
    [SeriesUpdateCycle] INT NOT NULL DEFAULT 0, 
    PRIMARY KEY ([SeriesId]) 
)
