using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using $ext_projectname$.Interface.Services;

namespace $safeprojectname$.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        protected readonly ILogger<CustomerController> _logger;
        protected readonly ICustomerService _customerService;
        public CustomerController(ILogger<CustomerController> logger,
                                  ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                var data = _customerService.GetCustomerByID(id);

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new StatusCodeResult(500);
            }
        }
    }
}
