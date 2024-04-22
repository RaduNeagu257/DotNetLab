using Microsoft.AspNetCore.Mvc;
using CompanyManagement.Core.Dtos.Response;
using CompanyManagement.Core.Dtos.Request;
using CompanyManagement.Core.Services;

namespace CompanyManagement.Api.Controllers
{
    [Route("api/Departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService _DepartmentService;
        public DepartmentsController(IDepartmentService DepartmentService)
        {
            _DepartmentService = DepartmentService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<List<DepartmentResponseDto>> GetDepartments()
        {
            return Ok(_DepartmentService.GetDepartments());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public ActionResult<int> CreateDepartment([FromBody] DepartmentRequestDto Department)
        {
            int id = _DepartmentService.CreateDepartment(Department);
            return StatusCode(StatusCodes.Status201Created, id);
        }
    }
}
