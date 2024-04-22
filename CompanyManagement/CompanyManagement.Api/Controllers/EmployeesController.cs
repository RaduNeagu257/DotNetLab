using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.Api.Controllers
{
    [Route("api/Employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _EmployeeService;

        public EmployeesController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<int> CreateEmployee([FromBody] EmployeeRequestDto Employee)
        {
            int id = _EmployeeService.CreateEmployee(Employee);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
