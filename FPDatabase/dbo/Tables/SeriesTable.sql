CREATE TABLE [dbo].[SeriesTable]
(
	[SeriesId] INT NOT NULL  IDENTITY, 
    [SeriesName] NVARCHAR(50) NULL, 
    [SeriesOriginalName] NVARCHAR(50) NULL, 
    [SeriesDescription] NVARCHAR(500) NULL, 
    [SeriesRating] REAL NOT NULL DEFAULT 0.0, 
    [SeriesSeasonCount] INT NOT NULL DEFAULT 0, 
    [SeriesEpisodeCount] INT NOT NULL DEFAULT 0, 
    [SeriesLatestEpisode] NVARCHAR(50) NULL, 
    [SeriesPosterURL] NVARCHAR(50) NULL, 
    [SeriesReleaseDate] BIGINT NULL, 
    [SeriesUpdateCycle] INT NOT NULL DEFAULT 0, 
    [SeriesBackgroundURL] NVARCHAR(50) NULL, 
    [SeriesOriginalLanguage] NVARCHAR(50) NULL, 
    [SeriesHomepage] NVARCHAR(50) NULL, 
    PRIMARY KEY ([SeriesId]) 
)
