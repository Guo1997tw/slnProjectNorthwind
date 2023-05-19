using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectNorthwind.Service.Interface;
using ProjectNorthwind.WebAPI.Models;

namespace ProjectNorthwind.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _customersServices;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerServices customersServices, IMapper mapper)
        {
            _customersServices = customersServices;
            _mapper = mapper;
        }

        [HttpGet("顧客清單")]
        public async Task<IActionResult> GetCustomerList()
        {
            var result = await _customersServices.GetCustomerUsersAsync();

            var response = new
            {
                Data = result,
                Output = new ResultOutputModel
                {
                    Success = true,
                    Massage = string.Empty
                }
            };

            return Ok(response);
        }
    }
}