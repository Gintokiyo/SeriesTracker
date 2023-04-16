using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
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
        [Route("/GetSingleSite")]
        public async Task<SiteModel?> SiteGetAsync(int id)
        {
            return await this._siteData.GetSingleSiteAsync(id);
        }

        [HttpPut]
        [Route("/PutSingleSite")]
        public async void SitePutAsync(SiteModel site)
        {
            await this._siteData.InsertSiteAsync(site);
        }

        [HttpGet]
        [Route("/GetAllSites")]
        public async Task<IEnumerable<SiteModel>> SiteGetAllAsync()
        {
            return await this._siteData.GetSiteAsync();
        }

        [HttpDelete]
        [Route("/DeleteSingleSite")]
        public async void SiteDeleteAsync(int id)
        {
            await this._siteData.DeleteSiteAsync(id);
        }

        [HttpPut]
        [Route("/UpdateSingleSite")]
        public async void SiteUpdateAsync(SiteModel site)
        {
            await this._siteData.UpdateSiteAsync(site);
        }
    }
}
