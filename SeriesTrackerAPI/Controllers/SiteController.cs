using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/SiteRoute")]
    public class SiteController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        private readonly ISiteData _siteData;

        public SiteController(ISqlDataAccess db)
        {
            this._db = db;
            this._siteData = new SiteData(this._db);
        }

        [HttpGet]
        public async Task<SiteModel?> SiteGetAsync(int id)
        {
            return await this._siteData.GetSingleSiteAsync(id);
        }

        [HttpPut]
        public async void SitePutAsync(SiteModel site)
        {
            await this._siteData.InsertSiteAsync(site);
        }
    }
}
