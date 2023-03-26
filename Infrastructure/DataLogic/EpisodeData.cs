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
    public class EpisodeData : IEpisodeData
    {
        private readonly ISqlDataAccess _db;

        public EpisodeData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<IEnumerable<EpisodeModel>> GetEpisodeAsync() =>
            _db.GetDataAsync<EpisodeModel, dynamic>("dbo.spEpisode_GetAll", new { });

        public async Task<EpisodeModel?> GetSingleEpisodeAsync(int id)
        {
            var results = await _db.GetDataAsync<EpisodeModel, dynamic>(
                "dbo.spEpisode_GetEntry",
                new { EpisodeId = id });
            return results.FirstOrDefault();
        }

        public Task InsertEpisodeAsync(EpisodeModel episode) =>
            _db.SaveDataAsync(
                "dbo.spEpisode_InsertEntry",
                new
                {
                    episode.EpisodeName,
                    episode.EpisodeNumber,
                    episode.EpisodeRating,
                    episode.EpisodeUrl,
                    episode.EpisodeReleaseDate,
                    episode.EpisodeSeriesId
                });

        public Task UpdateEpisodeAsync(EpisodeModel episode) =>
            _db.SaveDataAsync(
                "dbo.spEpisode_UpdateEntry",
                new
                {
                    episode.EpisodeId,
                    episode.EpisodeName,
                    episode.EpisodeNumber,
                    episode.EpisodeRating,
                    episode.EpisodeUrl,
                    episode.EpisodeReleaseDate,
                    episode.EpisodeSeriesId
                });

        public Task DeleteEpisodeAsync(int id) =>
            _db.SaveDataAsync(
                "dbo.spEpisode_DeleteEntry",
                new { EpisodeId = id });
    }
}
