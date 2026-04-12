using backend_lab.Models;
using backend_lab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService countryService;

        public CountryController()
        {
            countryService = new CountryService();
        }

        [HttpGet]
        public List<CountryModel> Get()
        {
            var paises = countryService.GetCountries();
            return paises;
        }

        [HttpPost]
        public ActionResult<bool> CreateCountry(CountryModel country)
        {
            if (country == null)
            {
                return BadRequest();
            }

            var result = countryService.CreateCountry(country);

            if (string.IsNullOrEmpty(result))
            {
                return Ok(true);
            }

            return BadRequest(result);
        }
    }
}