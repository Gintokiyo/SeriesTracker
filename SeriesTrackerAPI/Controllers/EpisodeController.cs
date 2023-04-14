using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/EpisodeRoute")]
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
        public async Task<EpisodeModel?> EpisodeGetAsync(int id)
        {
            return await this._episodeData.GetSingleEpisodeAsync(id);
        }

        [HttpPut]
        public async void EpisodePutAsync(EpisodeModel episode)
        {
            await this._episodeData.InsertEpisodeAsync(episode);
        }
    }
}
