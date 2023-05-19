using AutoMapper;
using ProjectNorthwind.Repository.Models;
using ProjectNorthwind.Service.Dtos;

namespace ProjectNorthwind.WebAPI.Mapping
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class WebAPIProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAPIProfile"/> class.
        /// </summary>
        public WebAPIProfile()
        {
            CreateMap<CustomerModel, CustomerDto>();
        }
    }
}