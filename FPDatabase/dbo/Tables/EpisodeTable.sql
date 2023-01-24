CREATE TABLE [dbo].[EpisodeTable]
(
	[EpisodeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EpisodeName] NVARCHAR(50) NULL, 
    [EpisodeNumber] NVARCHAR(50) NULL, 
    [EpisodeRating] REAL NOT NULL DEFAULT 0.0, 
    [EpisodeUrl] NVARCHAR(50) NULL, 
    [EpisodeReleaseDate] NVARCHAR(50) NULL, 
    [EpisodeSeriesId] INT NOT NULL, 
    CONSTRAINT [FK_EpisodeTable_SeriesTable] FOREIGN KEY ([EpisodeSeriesId]) REFERENCES [SeriesTable]([SeriesId])
)
