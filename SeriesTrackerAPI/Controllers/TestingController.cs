using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SeriesTrackerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/SeriesTrackerAPIRoute")]
    public class TestingController : ControllerBase
    {
        private PersonModel _person = new PersonModel 
        {
            PersonAge = 5,
            PersonCountryOfOrigin = "Ro",
            PersonId = 12,
            PersonName = "Foo",
        };

        [HttpGet]
        public PersonModel SeriesTrackerAPIGet()
        {
            return _person;
        }

        [HttpPost]
        public void SeriesTrackerAPIPost(PersonModel person)
        {
            _person = person;
        }

        [HttpPut]
        public void SeriesTrackerAPIPut(PersonModel person)
        {
            _person = person;
        }
    }
}
