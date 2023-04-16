using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
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
        [Route("/GetSingleSeries")]
        public async Task<SeriesModel?> SeriesGetAsync(int id)
        {
            return await this._seriesData.GetSingleSeriesAsync(id);
        }

        [HttpPut]
        [Route("/PutSingleSeries")]
        public async void SeriesPutAsync(SeriesModel series)
        {
            await this._seriesData.InsertSeriesAsync(series);
        }

        [HttpGet]
        [Route("/GetAllSeries")]
        public async Task<IEnumerable<SeriesModel>> SeriesGetAllAsync()
        {
            return await this._seriesData.GetSeriesAsync();
        }

        [HttpDelete]
        [Route("/DeleteSingleSeries")]
        public async void SeriesDeleteAsync(int id)
        {
            await this._seriesData.DeleteSeriesAsync(id);
        }

        [HttpPut]
        [Route("/UpdateSingleSeries")]
        public async void SeriesUpdateAsync(SeriesModel series)
        {
            await this._seriesData.UpdateSeriesAsync(series);
        }
    }
}
