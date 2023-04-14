using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/SeriesRoute")]
    public class SeriesController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        private readonly ISeriesData _seriesData;

        public SeriesController(ISqlDataAccess db) 
        { 
            this._db = db;
            this._seriesData = new SeriesData(this._db);
        }

        [HttpGet]
        public async Task<SeriesModel?> SeriesGetAsync(int id)
        {
            return await this._seriesData.GetSingleSeriesAsync(id);
        }

        [HttpPut]
        public async void SeriesPutAsync(SeriesModel series)
        {
            await this._seriesData.InsertSeriesAsync(series);
        }
    }
}
