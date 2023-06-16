using Content.Models;
using Infrastructure.DataLogic.Interface;
using Infrastructure.DbAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataLogic
{
    public class SeriesData : ISeriesData
    {
        private readonly ISqlDataAccess _db;

        public SeriesData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<IEnumerable<SeriesModel>> GetSeriesAsync() =>
            _db.GetDataAsync<SeriesModel, dynamic>("dbo.spSeries_GetAll", new { });

        public async Task<SeriesModel?> GetSingleSeriesAsync(int id)
        {
            var results = await _db.GetDataAsync<SeriesModel, dynamic>(
                "dbo.spSeries_GetEntry",
                new { SeriesId = id });
            return results.FirstOrDefault();
        }

        public Task InsertSeriesAsync(SeriesModel series) =>
            _db.SaveDataAsync(
                "dbo.spSeries_InsertEntry",
                new
                {
                    series.SeriesName,
                    series.SeriesOriginalName,
                    series.SeriesDescription,
                    series.SeriesRating,
                    series.SeriesSeasonCount,
                    series.SeriesEpisodeCount,
                    series.SeriesLatestEpisode,
                    series.SeriesPosterUrl,
                    series.SeriesReleaseDate,
                    series.SeriesUpdateCycle,
                    series.SeriesBackgroundUrl,
                    series.SeriesOriginalLanguage,
                    series.SeriesHomepage
                });

        public Task UpdateSeriesAsync(SeriesModel series) =>
            _db.SaveDataAsync(
                "dbo.spSeries_UpdateEntry",
                new
                {
                    series.SeriesId,
                    series.SeriesName,
                    series.SeriesOriginalName,
                    series.SeriesDescription,
                    series.SeriesRating,
                    series.SeriesSeasonCount,
                    series.SeriesEpisodeCount,
                    series.SeriesLatestEpisode,
                    series.SeriesPosterUrl,
                    series.SeriesReleaseDate,
                    series.SeriesUpdateCycle,
                    series.SeriesBackgroundUrl,
                    series.SeriesOriginalLanguage,
                    series.SeriesHomepage
                });

        public Task DeleteSeriesAsync(int id) =>
            _db.SaveDataAsync(
                "dbo.spSeries_DeleteEntry",
                new { SeriesId = id });

        public Task<IEnumerable<SeriesModel>> GetPageSeriesAsync(int firstEntry)
        {
            return _db.GetDataAsync<SeriesModel, dynamic>("dbo.spSeries_GetPage", new { first = firstEntry });
        }

    }
}
