using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/SeriesTrackerAPIRoute")]
    public class TestingController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        private readonly ISeriesData _seriesData;

        public TestingController(ISqlDataAccess db) 
        { 
            this._db = db;
            this._seriesData = new SeriesData(this._db);
        }

        [HttpGet]
        public async Task<SeriesModel?> SeriesTrackerAPIGetAsync(int id)
        {
            return await this._seriesData.GetSingleSeriesAsync(id);
        }

        [HttpPut]
        public async void SeriesTrackerAPIPut(SeriesModel series)
        {
            await this._seriesData.InsertSeriesAsync(series);
        }
    }
}
