CREATE TABLE [dbo].[PersonToSeriesBridge]
(
	[BridgeId] INT NOT NULL PRIMARY KEY, 
    [BridgePersonId] INT NOT NULL, 
    [BridgeSeriesId] INT NOT NULL, 
    CONSTRAINT [FK_PersonToSeriesBridge_PersonTable] FOREIGN KEY ([BridgePersonId]) REFERENCES [PersonTable]([PersonId]), 
    CONSTRAINT [FK_PersonToSeriesBridge_SeriesTable] FOREIGN KEY ([BridgeSeriesId]) REFERENCES [SeriesTable]([SeriesId])
)
