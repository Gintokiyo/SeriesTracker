using Content.Models;

namespace Infrastructure.DataLogic.Interface
{
    public interface IEpisodeData
    {
        Task DeleteEpisodeAsync(int id);
        Task<IEnumerable<EpisodeModel>> GetEpisodeAsync();
        Task<EpisodeModel?> GetSingleEpisodeAsync(int id);
        Task InsertEpisodeAsync(EpisodeModel episode);
        Task UpdateEpisodeAsync(EpisodeModel episode);
    }
}