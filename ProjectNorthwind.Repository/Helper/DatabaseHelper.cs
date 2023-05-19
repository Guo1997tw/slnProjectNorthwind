using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ProjectNorthwind.Repository.Helper
{
    public class DatabaseHelper : IDatabaseHelper
    {
        private readonly string? _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseHelper"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public DatabaseHelper(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("NorthwindContext");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseHelper"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <exception cref="System.ArgumentException">'{nameof(connectionString)}' 不得為 Null 或空白字元。 - connectionString</exception>
        public DatabaseHelper(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException($"'{nameof(connectionString)}' 不得為 Null 或空白字元。", nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}