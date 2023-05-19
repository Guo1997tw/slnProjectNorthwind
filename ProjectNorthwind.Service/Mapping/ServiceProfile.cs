using AutoMapper;
using ProjectNorthwind.Repository.Models;
using ProjectNorthwind.Service.Dtos;

namespace ProjectNorthwind.Service.Mapping
{
    public class ServiceProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProfile"/> class.
        /// </summary>
        public ServiceProfile()
        {
            CreateMap<CustomerModel, CustomerDto>();
        }
    }
}