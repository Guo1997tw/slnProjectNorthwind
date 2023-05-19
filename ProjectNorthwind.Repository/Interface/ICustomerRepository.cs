using ProjectNorthwind.Repository.Models;

namespace ProjectNorthwind.Repository.Interface
{
    public interface ICustomerRepository
    {
        Task<List<CustomerModel>> GetListAsync();
    }
}