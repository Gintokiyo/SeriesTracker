using Infrastructure.HelpFunctions;
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

        [HttpGet]
        [Route("/GetByExIdSeries")]
        public async Task<SeriesModel?> SeriesGetByExIdAsync(int id)
        {
            return await this._seriesData.GetByExIdAsync(id);
        }

        [HttpPost]
        [Route("/PostSingleSeries")]
        public async void SeriesPostAsync(SeriesModel series)
        {
            await this._seriesData.InsertSeriesAsync(series);
        }

        [HttpGet]
        [Route("/GetAllSeries")]
        public async Task<IEnumerable<SeriesModel>> SeriesGetAllAsync()
        {
            return await this._seriesData.GetSeriesAsync();
        }

        [HttpGet]
        [Route("/GetSearchSeries")]
        public async Task<IEnumerable<SeriesModel>> SeriesGetSearchAsync(string? search)
        {
            return await this._seriesData.GetSearchSeriesAsync(search);
        }

        [HttpGet]
        [Route("/GetPageSeries")]
        public async Task<IEnumerable<SeriesModel>> SeriesGetPageAsync(int page)
        {
            return await this._seriesData.GetPageSeriesAsync(HelpFunctions.FindFirstEntry(page));
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
