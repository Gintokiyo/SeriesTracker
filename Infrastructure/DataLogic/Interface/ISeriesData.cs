using Content.Models;

namespace Infrastructure.DataLogic.Interface
{
    public interface ISeriesData
    {
        Task DeleteSeriesAsync(int id);
        Task<IEnumerable<SeriesModel>> GetSeriesAsync();
        Task<SeriesModel?> GetSingleSeriesAsync(int id);
        Task InsertSeriesAsync(SeriesModel series);
        Task UpdateSeriesAsync(SeriesModel series);
        Task<IEnumerable<SeriesModel>> GetPageSeriesAsync(int first);
    }
}