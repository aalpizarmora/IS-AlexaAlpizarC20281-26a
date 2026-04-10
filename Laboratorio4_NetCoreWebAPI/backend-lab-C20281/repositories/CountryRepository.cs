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
    }
}