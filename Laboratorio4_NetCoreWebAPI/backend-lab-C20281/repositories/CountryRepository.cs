using backend_lab.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace backend_lab.Repositories
{
    public class CountryRepository
    {
        private readonly string connectionString;

        public CountryRepository()
        {
            var builder = WebApplication.CreateBuilder();
            connectionString = builder.Configuration.GetConnectionString("CountryContext");
        }

        public List<CountryModel> GetCountries()
        {
            using var connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM dbo.Countries";

            return connection.Query<CountryModel>(query).ToList();
        }

        public bool CreateCountry(CountryModel country)
        {
            using var connection = new SqlConnection(connectionString);

            var query = @"INSERT INTO [dbo].[Countries]
                          ([Name],[Language],[Continent])
                          VALUES(@Name, @Language, @Continent)";

            var affectedRows = connection.Execute(query, new
            {
                Name = country.Name,
                Language = country.Language,
                Continent = country.Continent
            });

            return affectedRows >= 1;
        }
    }
}