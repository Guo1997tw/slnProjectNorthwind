using Dapper;
using ProjectNorthwind.Repository.Helper;
using ProjectNorthwind.Repository.Models;
using ProjectNorthwind.Repository.Interface;

namespace ProjectNorthwind.Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDatabaseHelper _databaseHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        /// <param name="databaseHelper">The database helper.</param>
        public CustomerRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        /// <summary>
        /// Gets the list customers asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CustomerModel>> GetListAsync()
        {
            var ncs = _databaseHelper.GetConnection();

            var sqlCommand = @"SELECT CustomerID, CompanyName, ContactName,
                                      ContactTitle, Address, City, Region,
                                      PostalCode, Country, Phone, Fax
                               FROM [dbo].[Customers]";

            var sqlResult = await ncs.QueryAsync<CustomerModel>(sqlCommand);

            return sqlResult.ToList();
        }
    }
}