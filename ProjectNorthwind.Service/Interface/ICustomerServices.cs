using ProjectNorthwind.Service.Dtos;

namespace ProjectNorthwind.Service.Interface
{
    public interface ICustomerServices
    {
        Task<List<CustomerDto>> GetCustomerUsersAsync();
    }
}