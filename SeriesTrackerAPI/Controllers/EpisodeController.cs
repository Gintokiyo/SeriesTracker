using Content.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        private readonly IEpisodeData _episodeData;

        public EpisodeController(ISqlDataAccess db)
        {
            this._db = db;
            this._episodeData = new EpisodeData(this._db);
        }

        [HttpGet]
        [Route("/GetSingleEpisode")]
        public async Task<EpisodeModel?> EpisodeGetAsync(int id)
        {
            return await this._episodeData.GetSingleEpisodeAsync(id);
        }

        [HttpPut]
        [Route("/PutSingleEpisode")]
        public async void EpisodePutAsync(EpisodeModel episode)
        {
            await this._episodeData.InsertEpisodeAsync(episode);
        }

        [HttpGet]
        [Route("/GetAllEpisodes")]
        public async Task<IEnumerable<EpisodeModel>> EpisodeGetAllAsync()
        {
            return await this._episodeData.GetEpisodeAsync();
        }

        [HttpDelete]
        [Route("/DeleteSingleEpisode")]
        public async void EpisodeDeleteAsync(int id)
        {
            await this._episodeData.DeleteEpisodeAsync(id);
        }

        [HttpPut]
        [Route("/UpdateSingleEpisode")]
        public async void EpisodeUpdateAsync(EpisodeModel episode)
        {
            await this._episodeData.UpdateEpisodeAsync(episode);
        }
    }
}
