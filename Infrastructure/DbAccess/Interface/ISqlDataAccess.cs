using Microsoft.Extensions.Configuration;

namespace Infrastructure.DbAccess.Interface
{
    public interface ISqlDataAccess
    {
        IConfiguration Config { get; }

        Task<IEnumerable<T>> GetDataAsync<T, U>(
            string storedProcedure,
            U parameters,
            string connectionId = "Default");
        Task SaveDataAsync<T>(
            string storedProcedure,
            T parameters,
            string connectionId = "Default");
    }
}