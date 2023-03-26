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
    public class SiteData : ISiteData
    {
        private readonly ISqlDataAccess _db;

        public SiteData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<IEnumerable<SiteModel>> GetSiteAsync() =>
            _db.GetDataAsync<SiteModel, dynamic>("dbo.spSite_GetAll", new { });

        public async Task<SiteModel?> GetSingleSiteAsync(int id)
        {
            var results = await _db.GetDataAsync<SiteModel, dynamic>(
                "dbo.spSite_GetEntry",
                new { SiteId = id });
            return results.FirstOrDefault();
        }

        public Task InsertSiteAsync(SiteModel site) =>
            _db.SaveDataAsync(
                "dbo.spSite_InsertEntry",
                new
                {
                    site.SiteName,
                    site.SiteUrl,
                    site.SiteDescription,
                    site.SiteDateWhenAdded
                });

        public Task UpdateSiteAsync(SiteModel site) =>
            _db.SaveDataAsync(
                "dbo.spSite_UpdateEntry",
                new
                {
                    site.SiteId,
                    site.SiteName,
                    site.SiteUrl,
                    site.SiteDescription,
                    site.SiteDateWhenAdded
                });

        public Task DeleteSiteAsync(int id) =>
            _db.SaveDataAsync(
                "dbo.spSite_DeleteEntry",
                new { SiteId = id });
    }
}
