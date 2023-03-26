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
    public class PersonData : IPersonData
    {
        private readonly ISqlDataAccess _db;

        public PersonData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<IEnumerable<PersonModel>> GetPersonAsync() =>
            _db.GetDataAsync<PersonModel, dynamic>("dbo.spPerson_GetAll", new { });

        public async Task<PersonModel?> GetSinglePersonAsync(int id)
        {
            var results = await _db.GetDataAsync<PersonModel, dynamic>(
                "dbo.spPerson_GetEntry",
                new { PersonId = id });
            return results.FirstOrDefault();
        }

        public Task InsertPersonAsync(PersonModel person) =>
            _db.SaveDataAsync(
                "dbo.spPerson_InsertEntry",
                new
                {
                    person.PersonName,
                    person.PersonAge,
                    person.PersonCountryOfOrigin
                });

        public Task UpdatePersonAsync(PersonModel person) =>
            _db.SaveDataAsync(
                "dbo.spPerson_UpdateEntry",
                new
                {
                    person.PersonId,
                    person.PersonName,
                    person.PersonAge,
                    person.PersonCountryOfOrigin
                });

        public Task DeletePersonAsync(int id) =>
            _db.SaveDataAsync(
                "dbo.spPerson_DeleteEntry",
                new { PersonId = id });
    }
}
