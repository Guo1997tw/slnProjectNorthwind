using AutoMapper;
using ProjectNorthwind.Repository.Interface;
using ProjectNorthwind.Service.Dtos;
using ProjectNorthwind.Service.Interface;

namespace ProjectNorthwind.Service.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customersRepository;
        private readonly IMapper _mapper;

        public CustomerServices(ICustomerRepository customersRepository, IMapper mapper)
        {
            _customersRepository = customersRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets the customer users asynchronous.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CustomerDto>> GetCustomerUsersAsync()
        {
            var customerModel = await _customersRepository.GetListAsync();

            var customerDto = _mapper.Map<List<CustomerDto>>(customerModel);

            return customerDto;

            /*var result = customersModel.Select(c => new CustomersDto
            {
                CustomerID = c.CustomerID,
                CompanyName = c.CompanyName,
                ContactName = c.ContactName,
                ContactTitle = c.ContactTitle,
                Address = c.Address,
                City = c.City,
                Region = c.Region,
                PostalCode = c.PostalCode,
                Country = c.Country,
                Phone = c.Phone,
                Fax = c.Fax,
            }).ToList();*/
        }
    }
}