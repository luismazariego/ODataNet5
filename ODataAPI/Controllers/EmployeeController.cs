using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataAPI.Services;

namespace ODataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet(nameof(GetData))]
        //[EnableQuery(PageSize = 2)]
        [EnableQuery]
        public IActionResult GetData() => Ok(_employeeService.CreateData());
    }
}