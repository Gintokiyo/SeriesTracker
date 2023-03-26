using Content.Models;

namespace Infrastructure.DataLogic.Interface
{
    public interface ISiteData
    {
        Task DeleteSiteAsync(int id);
        Task<SiteModel?> GetSingleSiteAsync(int id);
        Task<IEnumerable<SiteModel>> GetSiteAsync();
        Task InsertSiteAsync(SiteModel site);
        Task UpdateSiteAsync(SiteModel site);
    }
}