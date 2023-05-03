using FinalProjectFront.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProjectFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISqlDataAccess _db;
        private readonly ISeriesData _data;

        public HomeController(ILogger<HomeController> logger, ISqlDataAccess db)
        {
            _logger = logger;
            this._db = db;
            this._data = new SeriesData(this._db);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ListSeriesAsync()
        {
            try
            {
                var incomingData = await this._data.GetSeriesAsync();
                return View(incomingData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }
        }

        [HttpGet]
        public IActionResult CreateSeries()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeriesAsync(SeriesModel series)
        {
            try
            {
                await this._data.InsertSeriesAsync(series);
                return View("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteSeriesAsync(int id)
        {
            try
            {
                var series = await this._data.GetSingleSeriesAsync(id);
                return View(series);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSeriesAsync(SeriesModel series)
        {
            try
            {
                await this._data.DeleteSeriesAsync(series.SeriesId);
                return View("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }
        }

        [HttpGet]
        public async Task<IActionResult> DetailsSeriesAsync(int id)
        {
            try
            {
                var series = await this._data.GetSingleSeriesAsync(id);
                return View(series);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditSeriesAsync(int id)
        {
            try
            {
                var series = await this._data.GetSingleSeriesAsync(id);
                return View(series);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }

        }

        [HttpPost]
        public async Task<IActionResult> EditSeriesAsync(SeriesModel series)
        {
            try
            {
                await this._data.UpdateSeriesAsync(series);
                return View("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}