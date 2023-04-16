using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ISqlDataAccess _db;
        private readonly IPersonData _personData;

        public PersonController(ISqlDataAccess db)
        {
            this._db = db;
            this._personData = new PersonData(this._db);
        }

        [HttpGet]
        [Route("/GetSinglePerson")]
        public async Task<PersonModel?> PersonGetAsync(int id)
        {
            return await this._personData.GetSinglePersonAsync(id);
        }

        [HttpPut]
        [Route("/PutSinglePerson")]
        public async void PersonPutAsync(PersonModel person)
        {
            await this._personData.InsertPersonAsync(person);
        }

        [HttpGet]
        [Route("/GetAllPersons")]
        public async Task<IEnumerable<PersonModel>> PersonGetAllAsync()
        {
            return await this._personData.GetPersonAsync();
        }

        [HttpDelete]
        [Route("/DeleteSinglePerson")]
        public async void PersonDeleteAsync(int id)
        {
            await this._personData.DeletePersonAsync(id);
        }

        [HttpPut]
        [Route("/UpdateSinglePerson")]
        public async void PersonUpdateAsync(PersonModel person)
        {
            await this._personData.UpdatePersonAsync(person);
        }
    }
}
