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

        public async Task<IEnumerable<SeriesModel>> GetSeriesAsync() =>
            await _db.GetDataAsync<SeriesModel, dynamic>("dbo.spSeries_GetAll", new { });

        public async Task<SeriesModel?> GetSingleSeriesAsync(int id)
        {
            var results = await _db.GetDataAsync<SeriesModel, dynamic>(
                "dbo.spSeries_GetEntry",
                new { SeriesId = id });
            return results.FirstOrDefault();
        }

        public async Task<SeriesModel?> GetByExIdAsync(int id)
        {
            var results = await _db.GetDataAsync<SeriesModel, dynamic>(
                "dbo.spSeries_GetByExId",
                new { externalId = id });
            return results.FirstOrDefault();
        }

        public async Task InsertSeriesAsync(SeriesModel series) =>
            await _db.SaveDataAsync(
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
                    series.SeriesHomepage,
                    series.SeriesExternalId
                });

        public async Task UpdateSeriesAsync(SeriesModel series) =>
            await _db.SaveDataAsync(
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
                    series.SeriesHomepage,
                    series.SeriesExternalId
                });

        public async Task DeleteSeriesAsync(int id) =>
            await _db.SaveDataAsync(
                "dbo.spSeries_DeleteEntry",
                new { SeriesId = id });

        public async Task<IEnumerable<SeriesModel>> GetPageSeriesAsync(int firstEntry)
            => await _db.GetDataAsync<SeriesModel, dynamic>("dbo.spSeries_GetPage", new { first = firstEntry });

        public async Task<IEnumerable<SeriesModel>> GetSearchSeriesAsync(string? searchTerm)
            => await _db.GetDataAsync<SeriesModel, dynamic>("dbo.spSeries_GetByName", new { search = searchTerm });
    }
}
