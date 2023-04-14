using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/PersonRoute")]
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
        public async Task<PersonModel?> PersonGetAsync(int id)
        {
            return await this._personData.GetSinglePersonAsync(id);
        }

        [HttpPut]
        public async void PersonPutAsync(PersonModel person)
        {
            await this._personData.InsertPersonAsync(person);
        }
    }
}
