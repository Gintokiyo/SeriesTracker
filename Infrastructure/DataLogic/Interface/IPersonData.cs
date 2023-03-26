using Content.Models;

namespace Infrastructure.DataLogic.Interface
{
    public interface IPersonData
    {
        Task DeletePersonAsync(int id);
        Task<IEnumerable<PersonModel>> GetPersonAsync();
        Task<PersonModel?> GetSinglePersonAsync(int id);
        Task InsertPersonAsync(PersonModel person);
        Task UpdatePersonAsync(PersonModel person);
    }
}