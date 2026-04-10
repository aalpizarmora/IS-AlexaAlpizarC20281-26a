using backend_lab.Models;
using backend_lab.Repositories;

namespace backend_lab.Services
{
    public class CountryService
    {
        private readonly CountryRepository countryRepository;

        public CountryService()
        {
            countryRepository = new CountryRepository();
        }

        public List<CountryModel> GetCountries()
        {
            // Add any missing business logic when it is necessary
            return countryRepository.GetCountries();
        }
    }
}